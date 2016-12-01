using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace DesignPattern
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id) { }
        public override Prototype Clone()
        {
            //浅表复制
            return (Prototype)this.MemberwiseClone();
        }
    }
}