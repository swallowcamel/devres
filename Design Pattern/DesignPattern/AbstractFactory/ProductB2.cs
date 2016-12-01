using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// 特定的产品B-2
    /// </summary>
    public class ProductB2 : AbstractProductB
    {
        /// <summary>
        /// 与产品A做个交互
        /// </summary>
        /// <param name="a"></param>
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}