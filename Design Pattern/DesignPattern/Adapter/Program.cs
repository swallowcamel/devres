using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =================适配器模式 Adapter ======================
 *  
 * 意图：将一个类的接口转换成客户希望的另外一个接口。Adapter模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。
 *  
 * 适用：1、你想使用一个已经存在的类，而它的接口不符合你的需求。 
 *      2、你想创建一个可以复用的类，该类可以与其他不相关的类或不可预见的类（即那些接口可能不一定兼容的类）协同工作。
 *      （仅适用于对象Adapter）你想使用一些已经存在的子类，但是不可能对每一个都进行子类化以匹配它们的接口。
 *      对象适配器可以适配它的父类接口。
 * 
 * 参考："Design Patterns", p139,ISBN:0-201-63361-2
 * 
 * 解析：GoF的设计模式中 适配器包含 类适配器模式和对象适配器模式两种。类适配器主要是通过多继承来实现的，然而在C#语言中是不能多继承的。
 *      所以这里的适配器模式主要是指 对象适配器模式。
 */
 

namespace DesignPattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            Console.Read();
        }
    }
}
