using ExpertSystemShellDomain.Entities;

namespace ExpertSystemShellDomain;

public class InferentialMechanism
{
    private readonly KnowledgeBase _knowledgeBase;
    private readonly WorkingMemory _workingMemory;
    private readonly IExpertSystemIo _io;
    private readonly HashSet<Rule> _processedRules;
    private bool _isInferringStopped;

    public InferentialMechanism(KnowledgeBase knowledgeBase, WorkingMemory workingMemory, IExpertSystemIo io)
    {
        _knowledgeBase = knowledgeBase;
        _workingMemory = workingMemory;
        _io = io;
        _processedRules = new HashSet<Rule>();
        _isInferringStopped = false;
    }

    public void StartInference(Variable targetVariable)
    {
        _io.InitIo();
        
        // Starting inference with requested variable is forbidden.  
        if (targetVariable.VariableType == VarType.Requested)
            return;

        // Call recursive function to infer variable value
        Infer(targetVariable);

        var variableValueFromMemory = GetVariableValueFromMemory(targetVariable);
        if (variableValueFromMemory is null)
        {
            _io.ShowMessage("Цель консультации не была достигнута. Обратитесь к другой ЭС.", "Результат консультации");
            return;
        }
        
        _io.ShowMessage($"Цель консультации достугнута! Результат: {targetVariable.Name} - {variableValueFromMemory}", "Результат консультации");
        _io.ShowExplanation(_workingMemory);
    }

    private void Infer(Variable targetVariable)
    {
        // Recursion stop condition - variable is already inferred
        if (_isInferringStopped || GetVariableValueFromMemory(targetVariable) is not null)
            return;
        
        // Get variable value from IO from and set value in work memory
        if (targetVariable.VariableType == VarType.Requested)
        {
            var requiredValue = _io.CreateVariableRequest(targetVariable);
            if (requiredValue is null)
            {
                _isInferringStopped = true;
                return;
            }

            _workingMemory.VariableValues.Add(targetVariable, requiredValue);
            return;
        }

        // 1. Сначала выбирается правило, в заключении которого может быть определено значение целевой переменной,
        // если таких правил несколько, то обычно рассматривается первое из них

        foreach (var targetRule in _knowledgeBase.Rules)
        {
            if (targetRule.Conclusions.All(c => c.Variable != targetVariable))
                continue;

            // 3. проверяется посылка выбранного правила; если она верна, то правило включается, и целевая переменная получает значение
            bool isRuleFired = true;
            foreach (var premise in targetRule.Premises)
            {
                // 4. если в посылке содержатся неизвестные переменные, то они рассматриваются как временные целевые переменные (временные цели).
                // Значения таких переменных определяются аналогично тому, как это делается для основной цели: из базы знаний выбираются правила,
                // в которых временная цель может получить значение, проверяются посылки этих правил и т.д.
                // 5. в процессе поиска значения временной цели другие переменные также могут становиться временными целями

                var variableValue = GetVariableValueFromMemory(premise.Variable); 
                if (variableValue is null && !_processedRules.Contains(targetRule))
                {
                    _processedRules.Add(targetRule);
                    Infer(premise.Variable);
                    _processedRules.Remove(targetRule);
                    
                    variableValue = GetVariableValueFromMemory(premise.Variable);
                }

                // Rule won't fire if mechanism couldn't infer or one of the premises if false 
                if (variableValue is null || premise.DomainValue != variableValue)
                {
                    isRuleFired = false;
                    break;
                }
            }
        
            // 6. после определения всех неизвестных переменных, содержавшихся в посылке правила,
            // происходит проверка посылки; если она верна, то правило включается, и целевая переменная получает значение
            if (isRuleFired)
            {
                _workingMemory.FiredRules.Add(targetRule);
                
                foreach (var conclusion in targetRule.Conclusions)
                {
                    // Exceptions shouldn't happen but using TryAdd just in case 
                    _workingMemory.VariableValues.TryAdd(conclusion.Variable, conclusion.DomainValue);
                }
                break;
            }

            // 7. если посылка правила оказывается неверной (или некоторые из неизвестных переменных не удается найти), то правило не включается, и рассматривается следующее правило, в котором целевая переменная может получить значение
            // 8. процесс продолжается, пока не будет найдено значение целевой переменной (или будет установлено, что найти его невозможно)    
        }
    }

    private DomainValue? GetVariableValueFromMemory(Variable variable)
    {
        _workingMemory.VariableValues.TryGetValue(variable, out DomainValue? variableValue);
        return variableValue;
    }
}