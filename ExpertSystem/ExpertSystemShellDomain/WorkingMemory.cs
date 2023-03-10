using ExpertSystemShellDomain.Entities;

namespace ExpertSystemShellDomain;

public class WorkingMemory
{
    public List<Rule> FiredRules { get; }
    public Dictionary<Variable, DomainValue> VariableValues { get; }
    
    public WorkingMemory()
    {
        FiredRules = new List<Rule>();
        VariableValues = new Dictionary<Variable, DomainValue>();
    }
}