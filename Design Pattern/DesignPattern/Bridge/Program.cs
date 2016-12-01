using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* 
 * =================桥接模式 Bridge ======================
 *  
 * 意图：将抽象部分与它的实现部分分离，使它们都可以独立地变化。
 *      
 *      “将抽象部分与它的实现部分分离”通俗的讲就是：
 *      实现系统可能有多角度分类，每一种分类都有可能变化，
 *      那么就把这种多角度分离出来让它们独立变化，减少它们之间的耦合。
 *      
 * 适用：在发现需要多角度去分类实现对象，而只用继承会造成大量的类增加不能满足开放粉笔原则时。
 * 
 * 参考："Design Patterns", p151,ISBN:0-201-63361-2
 * 解析：
 * 
 */

namespace DesignPattern.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            ab.SetImplementor(new ConcreteImplementorA());
            ab.Operation();

            ab.SetImplementor(new ConcreteImplementorB());
            ab.Operation();

            Console.Read();
        }
    }
}
