namespace ExpertSystemShellDomain.Entities
{
    public class KnowledgeBase
    {
        public List<Domain> Domains { get; } = new();
        public List<Variable> Variables { get; } = new();
        public List<Rule> Rules { get; } = new();

        public Rule? GetRuleByName(string name) => Rules.FirstOrDefault(r => r.Name == name);

        public Domain? GetDomainByName(string name) => Domains.FirstOrDefault(d => d.Name == name);

        public Variable? GetVariableByName(string name) => Variables.FirstOrDefault(v => v.Name == name);
        
        public List<Variable> GetVariablesByDomain(Domain domain) => Variables.Where(l => l.Domain == domain).ToList();

        public List<Rule> GetRulesByVariable(Variable variable)
        {
            var rules = new List<Rule>();
            foreach (var rule in Rules)
            {
                foreach (var fact in rule.Conclusions.Concat(rule.Premises))
                {
                    if (fact.Variable == variable)
                    {
                        rules.Add(rule);
                        break;
                    }
                }
            }

            return rules;
        }

        public List<Rule> GetRulesByDomainValues(List<DomainValue> domainValues)
        {
            var rules = new List<Rule>();
            foreach (var rule in Rules)
            {
                foreach (var fact in rule.Conclusions.Concat(rule.Premises))
                {
                    if (domainValues.Any(domainValue => fact.DomainValue == domainValue))
                    {
                        rules.Add(rule);
                        break;
                    }
                }
            }

            return rules;
        }

        /// <summary>
        /// Find rules where in its facts is using domain value.  
        /// </summary>
        public List<Rule> GetRulesByDomainValue(DomainValue domainValue)
        {
            var rules = new List<Rule>();

            foreach (var rule in Rules)
            {
                foreach (var fact in rule.Conclusions.Concat(rule.Premises))
                {
                    if (fact.DomainValue == domainValue)
                    {
                        rules.Add(rule);
                        break;
                    }
                }
            }
            return rules;
        }
    }
}
