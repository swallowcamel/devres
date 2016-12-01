using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Strategy
{
    public class ConcreteStrategyB : AbstractStrategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法 B");
        }
    }
}