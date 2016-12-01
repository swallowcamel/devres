using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Strategy
{
    public class ConcreteStrategyA : AbstractStrategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法 A");
        }
    }
}