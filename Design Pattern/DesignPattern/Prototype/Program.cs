using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* 
 * =================原型模式 Prototype======================
 * 
 * 定义：用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。[DP]
 *  
 * 适用：当要实例化的类是在运行时刻指定时，例如，通过动态装载；
 *      或者为了避免创建一个与产品类层次平行的工厂类层次时；
 *      或者当一个类的实例只能有几个不同状态组合中的一种时。
 *      建立相应数目的原型并克隆它们可能比每次用合适的状态手工实例化该类更方便一些。 
 *  
 * 参考："Design Patterns", p117,ISBN:0-201-63361-2
 * 
 * 注意： 浅复制和深复制的问题。
 *       1、“浅复制”，被复制对象的所有变量都含有与原来的对象相同的值，而所有的对其他对象的引用都仍然指向原来的对象。
 *       2、“深复制”，把引用对象的变量指向复制过的新对象，而不是原有的被引用的对象。
 * 
 * ================================================================
 */
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("克隆: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("克隆: {0}", c2.Id);

            Console.Read();

        }
    }
}
