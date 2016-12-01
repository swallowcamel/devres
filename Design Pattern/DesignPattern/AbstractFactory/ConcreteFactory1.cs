using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// 具体的工厂1
    /// </summary>
    public class ConcreteFactory1 : AbstractFactory
    {
        /// <summary>
        /// 创建 定制 产品A-1
        /// </summary>
        /// <returns></returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        /// <summary>
        /// 创建 定制 产品B-1
        /// </summary>
        /// <returns></returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}