using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =====================享元模式 Flyweight=========================
 * 
 * 意图：运用共享技术有效地支持大量细粒度的对象。
 *  
 * 适用：1、如果一个应用程序使用了大量对象，而大量的对象造成了很大的存储开销时就应该考虑使用；
 *      2、还有就是对象的大多数状态可以外部状态，如果删除对象的外部状态，那么可以用相对较少的共享对象取代很多组对象，此时可以考虑使用享元模式。
 * 
 * 参考："Design Patterns", p185,ISBN:0-201-63361-2
 * 
 * 内部状态：在享元对象内部且不会随环境改变而改变的共享部分；
 * 外部状态：随环境改变而改变的，不可以共享的状态；
 * 
 * 好处：享元模式可以避免大量非常相似类的开销。在程序设计中，有时需要生成大量细粒度的类实例来表示数据。
 *  如果能发现这些实例除了几个参数外基本上都是相同的，有时就能够大幅度的减少需要实例化的类的数量。
 *  如果能够把那些参数移到类实例的外面，在方法调用时将它们传递进来，就可以通过共享大幅度的减少单个实例的数目。
 * 
 * 问题：享元模式需要维护一个记录了系统已有的所有享元的列表，而这本身需要耗费资源，另外享元模式使得系统更加复杂，为了使对象可以共享，
 *      需要将一些状态外部化，这使得程序的逻辑复杂化。所以应当在有足够多的对象实例可供共享时才值得使用享元模式。
 * 
 * PS：.Net 中 String 就是运用了Flyweight模式。
 *     可以用 Object.ReferenceEquals(object a,object b) 来验证。
 *     
 *     享元模式更多的时候是一种底层的设计模式，现实中的案例也有一些比如休闲棋牌类游戏。
 *     
 * 
 */

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
              int extrinsicstate = 22;

            FlyweightFactory f = new FlyweightFactory();

            Flyweight fx = f.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = f.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = f.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();

            uf.Operation(--extrinsicstate);

            Console.Read();
        }
    }
}
