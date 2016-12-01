using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =====================模板方法 TemplateMethod=========================
 * 
 * 定义：定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。
 *      模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。[DP]
 *  
 * 适用：当不变的和可变的行为在方法的子类实现中混合在一起的时候，不变的行为就会在子类中重复出现。
 *      通过模板方法模式把这些行为搬移到单一的地方这样就帮助子类摆脱重复的不变行为的纠缠。 
 *      
 * 
 * 参考："Design Patterns", p325,ISBN:0-201-63361-2
 
 * 特点：模板方法模式通过把不变行为搬移到超类，去除子类中的重复代码来体现它的优势。
 *      模板方法模式就是提供一个很好的代码复用平台。
 * 
 * 
 */

namespace DesignPattern.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass c;

            c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();

            Console.Read();

        }
    }
}
