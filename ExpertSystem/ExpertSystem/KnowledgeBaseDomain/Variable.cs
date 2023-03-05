using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.KnowledgeBaseDomain
{
    public class Variable
    {
        public string Name { get; set; }
        public Domain Domain { get; set; }
        public VarType VariableType { get; set; }
        public string QuestionText { get; set; }

        public Variable(string name, Domain value, VarType variableType, string questionText)
        {
            Name = name;
            Domain = value;
            VariableType = variableType;
            QuestionText = questionText;
        }

        public override string ToString() => Name;

        public Variable DeepCopy()
        {
            return new Variable(Name, Domain, VariableType, QuestionText);
        }
    }
}
