using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.KnowledgeBaseDomain
{
    public class DomainValue
    {
        public string Value { get; set; }

        public DomainValue(string value)
        {
            Value = value;
        }

        public override string ToString() => Value;
    }
}
