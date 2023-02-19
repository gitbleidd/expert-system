using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.Entities
{
    public class ExpertSystemShell
    {
        public List<Domain> Domains { get; } = new();
        public List<Variable> Variables { get; } = new();
        public List<Rule> Rules { get; } = new();

        public Rule? GetRuleByName(string name) => Rules.FirstOrDefault(r => r.Name == name);

        public Domain? GetDomainByName(string name) => Domains.FirstOrDefault(d => d.Name == name);

        public Variable? GetVariableByDomain(Domain domain) => Variables.FirstOrDefault(l => l.Domain == domain);

        public Variable? GetVariableByName(string name) => Variables.FirstOrDefault(v => v.Name == name);

        public Domain? GetDomainByDomainValue(DomainValue domainValue)
        {
            foreach (var domain in Domains)
            {
                if (domain.Values.FirstOrDefault(v => v == domainValue) != null)
                {
                    return domain;
                }
            }
            return null;
        }

        public (Rule, Fact)? GetRuleAndFactByDomainValue(DomainValue domainValue)
        {
            foreach (var rule in Rules)
            {
                foreach (var fact in rule.Premises)
                {
                    if (fact.DomainValue != domainValue)
                    {
                        return new (rule, fact);
                    }
                }
                foreach (var fact in rule.Conclusions)
                {
                    if (fact.DomainValue != domainValue)
                    {
                        return (rule, fact);
                    }
                }
            }
            return null;
        }

        public (Rule, Fact)? GetFactByVariable(Variable variable)
        {
            foreach (var rule in Rules)
            {
                foreach (var fact in rule.Premises)
                {
                    if (fact.Variable != variable)
                    {
                        return (rule, fact);
                    }
                }
                foreach (var fact in rule.Conclusions)
                {
                    if (fact.Variable != variable)
                    {
                        return (rule, fact);
                    }
                }
            }
            return null;
        }
    }
}
