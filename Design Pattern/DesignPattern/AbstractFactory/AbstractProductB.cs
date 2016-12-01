using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// 抽象产品B
    /// </summary>
    /// <remarks>因为可能有两种不同的实现。</remarks>
    public abstract class AbstractProductB
    {
        /// <summary>
        /// 与产品A做个交互
        /// </summary>
        /// <param name="a"></param>
        public abstract void Interact(AbstractProductA a);
    }
}