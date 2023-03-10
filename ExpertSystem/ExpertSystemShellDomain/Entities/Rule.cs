namespace ExpertSystemShellDomain.Entities
{
    public class Rule
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Fact> Premises { get; set; } = new();
        public List<Fact> Conclusions { get; set; } = new();

        public Rule(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString() => Name;
    }
}
