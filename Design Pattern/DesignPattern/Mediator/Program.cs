using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =================中介者模式 Mediator ======================
 *  
 * 意图：用一个中介对象来封装一系列的对象交互。
 *      中介者使得各对象不需要显式地相互引用，从而使其耦合松散，而且可以对立地
 *      改变它们之间的交互。
 *  
 * 适用：1、一组对象以定义良好但是复杂的方式进行通信。产生的相互依赖关系结构混乱且难以理解。 
 *      2、一个对象引用其他很多对象并且直接与这些对象通信,导致难以复用该对象。 
 *      3、想定制一个分布在多个类中的行为，而又不想生成太多的子类。 
 *  
 * 参考："Design Patterns", p273,ISBN:0-201-63361-2
 * 
 * 解析： 
 */


namespace DesignPattern.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("吃过饭了吗?");
            c2.Send("没有呢，你打算请客？");

            Console.Read();
        }
    }
}
