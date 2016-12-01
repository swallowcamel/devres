using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* 
 * =================访问者模式 Visitor ======================
 *  
 * 意图：表示一个作用于某对象结构中的各元素的操作。它使你可以在不改变各元素的前提下定义作用于这些元素的新操作。
 *  
 * 适用：1、有稳定的数据结构，又有易于变化的算法。
 *  
 * 参考："Design Patterns", p331,ISBN:0-201-63361-2
 * 
 * 优点：增加新的操作很容易，因为增加新的操作久意味着增加了一个性的访问者。访问者模式将有关的行为集中到一个访问者对象中。
 * 
 * 不足：使得增加新的数据结构变得困难。
 *      
 * 
 */
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
              ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            o.Accept(v1);
            o.Accept(v2);

            Console.Read();
        }
    }
}
