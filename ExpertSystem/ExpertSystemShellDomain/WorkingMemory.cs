using ExpertSystemShellDomain.Entities;

namespace ExpertSystemShellDomain;

public class WorkingMemory
{
    public List<Rule> FiredRules { get; }
    public Dictionary<Variable, DomainValue> VariableValues { get; }
    public Variable? TargetVariable { get; }
    
    public WorkingMemory()
    {
        FiredRules = new List<Rule>();
        VariableValues = new Dictionary<Variable, DomainValue>();
        TargetVariable = null;
    }

    public WorkingMemory(Variable targetVariable)
    {
        FiredRules = new List<Rule>();
        VariableValues = new Dictionary<Variable, DomainValue>();
        TargetVariable = targetVariable;
    }
}