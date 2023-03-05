using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.KnowledgeBaseDomain
{
    public enum VarType
    {
        Requested,
        Inferred,
        InferredRequested
    }

    public static class EnumExtension
    {
        public static string GetName(this VarType varType)
        {
            switch (varType)
            {
                case VarType.Requested:
                    return "Запрашиваемая";
                case VarType.Inferred:
                    return "Выводимая";
                case VarType.InferredRequested:
                    return "Выводимо-запрашиваемая";
                default:
                    throw new Exception("Undefiend enum value");
            }
        }
    }
}
