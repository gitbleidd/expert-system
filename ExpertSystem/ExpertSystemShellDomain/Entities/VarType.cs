namespace ExpertSystemShellDomain.Entities
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
