using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// 具体的工厂2
    /// </summary>
    public class ConcreteFactory2 : AbstractFactory
    {
        /// <summary>
        /// 创建 定制 产品A-2
        /// </summary>
        /// <returns></returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        /// <summary>
        /// 创建 定制 产品B-2
        /// </summary>
        /// <returns></returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}