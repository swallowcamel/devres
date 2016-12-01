using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Strategy
{
    public class Context
    {
        /// <summary>
        /// 策略模式上下文构造函数
        /// </summary>
        public Context(AbstractStrategy strategy)
        {
            _strategy = strategy;
        }


        /// <summary>
        /// 与简单工厂整合后的 策略模式上下文
        /// </summary>
        /// <param name="strategy"></param>
        public Context(string strategy)
        {
            switch (strategy)
            {
                case "StrategyA":
                    _strategy = new ConcreteStrategyA();
                    break;
                case "StrategyB":
                    _strategy = new ConcreteStrategyA();
                    break;
                case "StrategyC":
                    _strategy = new ConcreteStrategyA();
                    break;
                default:
                    throw new NotSupportedException();
            }
        }


        private AbstractStrategy _strategy;

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}