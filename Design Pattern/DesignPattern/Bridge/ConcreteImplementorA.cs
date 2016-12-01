using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class ConcreteImplementorA : Implementor
    {
           public override void OperationImpl()
        {
            Console.WriteLine("具体实现A的方法执行");
        }
    }
}