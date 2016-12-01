using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Decorator
{
    /// <summary>
    /// ConcreteDecorator 具体的装饰对象，起到给Component添加功能的作用
    /// </summary>
    public class ConcreteDecoratorA : AbstractDecorator
    {
        private string addedState;

        public override void Operation()
        {
             base.Operation();
            addedState = "New State";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
}