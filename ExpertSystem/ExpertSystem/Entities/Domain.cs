﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem.Entities
{
    public class Domain
    {
        public string Name { get; set; }
        public List<DomainValue> Values { get; } = new();

        public Domain(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

        public DomainValue? GetDomainValue(string value) => Values.FirstOrDefault(v => v.Value == value);
    }
}
