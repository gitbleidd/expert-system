using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.KnowledgeBaseDomain
{
    public enum VarType
    {
        Required,
        Produce,
        ProduceInquire
    }

    public static class EnumExtention
    {
        public static string GetName(this VarType varType)
        {
            switch (varType)
            {
                case VarType.Required:
                    return "Запрашиваемая";
                case VarType.Produce:
                    return "Выводимая";
                case VarType.ProduceInquire:
                    return "Выводимо-запрашиваемая";
                default:
                    throw new Exception("Undefiend enum value");
            }
        }
    }
}
