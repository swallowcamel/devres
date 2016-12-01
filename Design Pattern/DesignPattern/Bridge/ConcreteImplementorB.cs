using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class ConcreteImplementorB : Implementor
    {
          public override void OperationImpl()
        {
            Console.WriteLine("具体实现B的方法执行");
        }
    }
}