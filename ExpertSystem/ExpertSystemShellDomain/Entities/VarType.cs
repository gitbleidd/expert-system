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
            return varType switch
            {
                VarType.Requested => "Запрашиваемая",
                VarType.Inferred => "Выводимая",
                VarType.InferredRequested => "Выводимо-запрашиваемая",
                _ => throw new Exception("Undefiend enum value")
            };
        }
    }
}
