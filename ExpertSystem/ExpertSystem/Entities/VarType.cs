using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.Entities
{
    public enum VarType
    {
        Inquire,
        Produce,
        InquireProduce,
        //ProduceInquire
    }

    public static class EnumExtention
    {
        public static string GetName(this VarType varType)
        {
            switch (varType)
            {
                case VarType.Inquire:
                    return "Запрашиваемая";
                case VarType.Produce:
                    return "Выводимая";
                case VarType.InquireProduce:
                    return "Запрашиваемо-выводимая";
                //case VarType.ProduceInquire:
                //    return "Выводимо-запрашиваемая";
                default:
                    throw new Exception("Undefiend enum value");
            }
        }
    }
}
