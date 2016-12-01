using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class RefinedAbstraction : Abstraction
    {
            public override void Operation()
        {
            implementor.OperationImpl();
        }
    }
}