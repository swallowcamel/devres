using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/* 
 * =================抽象工厂 AbstractFactory======================
 * 
 * 意图：提供一个创建一系列相关或互相依赖对象的接口，而无需指定它们的具体的类。[DP]
 *  
 * 适用：1、一个系统要独立于它的产品的创建、组合和表示时。
 *      2、一个系统要由多个产品系列中的一个来配置时。 
 *      3、当你要强调一系列相关的产品对象的设计以便进行联合使用时。 
 *      4、当你提供一个产品类库，而只想显示它们的接口而不是实现时。
 *  
 * 参考："Design Patterns", p87,ISBN:0-201-63361-2
 * 
 *  好处：
 *    	易于交换产品系列，由于具体的工厂类,在一个应用中只需要在初始化的时候出现一次，
 *    	这就使得改变一个应用的具体工厂变得非常容易，它只需要改变具体工厂即可使用不同的产品配置。
 *  	它让具体的创建实例与客户端分离，客户端是通过它们的抽象接口操纵实例，产品的具体类名也被具体工厂的实现分离，不会出现在客户代码中。
 *  	
 *  缺点：如果需要增加/修改功能就会有大量的代码改动。编程是门艺术，这样大批量的改动，显然是非常丑陋的做法。
 *  
 *  改进：
 *  	1、用简单工厂改进抽象工厂。
 *  	2、用反射+抽象工厂。
 * 
 * 
 * PS： 为创建不同的产品对象，客户端应该使用不同的具体工厂。
 * ================================================================
 */

namespace DesignPattern.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.Read();
        }
    }
}