﻿namespace ExpertSystemShellDomain.Entities
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
