using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    ///UnsharedConcreteFlyweight是指那些不需要共享的Flyweight子类。
    /// 因为Flyweight接口共享成为可能，但它不强制共享。
    /// </summary>
    public class UnsharedConcreteFlyweight : Flyweight
    {
         public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("不共享的具体Flyweight:" + extrinsicstate);
        }
    }
}