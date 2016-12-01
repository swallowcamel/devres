using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Decorator
{
    public class ConcreteComponent : AbstractComponent
    {
         public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }
}