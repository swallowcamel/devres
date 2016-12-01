using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Decorator
{
   /// <summary>
    /// ConcreteDecorator 具体的装饰对象，起到给Component添加功能的作用
    /// </summary>
    public class ConcreteDecoratorB : AbstractDecorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作。");
        }

        private void AddedBehavior()
        {
            Console.WriteLine("具体装饰对象B添加的行为。");
        }
    }
}