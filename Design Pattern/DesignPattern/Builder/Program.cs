using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =================建造者模式 Builder======================
 * 
 * 定义：将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。[DP]
 *  
 * 适用：1、当创建复杂对象的算法应该独立于该对象的组成部分以及它们的装配方式时适用。 
 *      2、当构造过程必须允许被构造的对象有不同的表示时适用。
 *      
 * 参考："Design Patterns", p97,ISBN:0-201-63361-2
 * 
 * 注意：建造者模式好处就是使得建造代码与表示代码分离，由于建造者隐藏了该产品是如何组装的，
 *      所以若需要改变一个产品的内部表示，只需要再定义一个具体的建造者就可以了。
 *      
 *      
 * ================================================================
 */


namespace DesignPattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.Read();
        }
    }
}
