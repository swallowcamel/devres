using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA elementA);

        public abstract void VisitConcreteElementB(ConcreteElementB elementB);
    }
}