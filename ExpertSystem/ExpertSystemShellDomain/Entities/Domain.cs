namespace ExpertSystemShellDomain.Entities
{
    public class Domain
    {
        public string Name { get; set; }
        public List<DomainValue> Values { get; set; } = new();

        public Domain(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

        public DomainValue? GetDomainValue(string value) => Values.FirstOrDefault(v => v.Value == value);

        public Domain DeepCopy()
        {
            var domain = new Domain(Name);
            foreach (var value in Values)
            {
                domain.Values.Add(new DomainValue(value.Value));
            }
            return domain;
        }
    }
}
