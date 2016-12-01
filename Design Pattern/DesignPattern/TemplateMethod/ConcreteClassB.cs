﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
           Console.WriteLine("具体类B方法1实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类B方法2实现");
        }
    }
}