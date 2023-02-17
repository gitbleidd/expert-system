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

        public Domain? GetDomainByName(string name) => Domains.FirstOrDefault(d => d.Name == name);
    }
}
