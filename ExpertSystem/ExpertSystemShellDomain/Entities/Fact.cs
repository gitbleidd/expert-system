namespace ExpertSystemShellDomain.Entities
{
    public class Fact
    {
        public Variable Variable { get; set; }
        public DomainValue DomainValue { get; set; }

        public Fact(Variable variable, DomainValue domainValue)
        {
            Variable = variable;
            DomainValue = domainValue;  
        }

        public override string ToString() => $"{Variable.Name} = {DomainValue.Value}";
    }
}
