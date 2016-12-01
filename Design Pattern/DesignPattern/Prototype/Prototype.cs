using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public abstract class Prototype
    {
        public Prototype(string id)
        {
            Id = id;
        }
        public string Id{get; set; }

        public abstract Prototype Clone();
    }
}