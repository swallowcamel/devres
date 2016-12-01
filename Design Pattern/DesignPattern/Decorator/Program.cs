using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =====================装饰模式 Decorator=========================
 * 
 * 定义：动态地给一个对象添加一些额外的职责，就增加功能来说，装饰模式比生成子类更为灵活。[DP]
 *  
 * 适用：1、在不影响其他对象的情况下，以动态、透明的方式给单个对象添加职责。 
 *      2、处理那些可以撤消的职责。 
 *      3、当不能采用生成子类的方法进行扩充时。一种情况是，可能有大量独立的扩展，
 *      为支持每一种组合将产生大量的子类，使得子类数目呈爆炸性增长。
 *      另一种情况可能是因为类定义被隐藏，或类定义不能用于生成子类。  
 * 
 * 参考："Design Patterns", p175,ISBN:0-201-63361-2
 
 * 注意：
 * 
 * 
 * 
 */
namespace DesignPattern.Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent component = new ConcreteComponent();
            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();

            decoratorA.SetComponent(component);
            decoratorB.SetComponent(decoratorA);

            decoratorB.Operation();

            Console.Read();
        }
    }
}
