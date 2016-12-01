using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// 创建产品A
        /// </summary>
        /// <returns></returns>
        public abstract AbstractProductA CreateProductA();

        /// <summary>
        /// 创建产品B
        /// </summary>
        /// <returns></returns>
        public abstract AbstractProductB CreateProductB();
    }
}