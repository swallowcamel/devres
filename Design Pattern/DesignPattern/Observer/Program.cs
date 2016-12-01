using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =================观察者模式 Observer ======================
 *  
 * 定义：定义了一种一对多的依赖关系，让多个观察者对象同时监听某一个主题对象。
 *      这个主题对象在状态发生变化时，会通知所有观察者对象，使他们能够自动更新自己。[DP]
 *  
 * 适用：1、当一个抽象模型有两个方面, 其中一个方面依赖于另一方面。将这二者封装在独立的对象中以使它们可以各自独立地改变和复用。 
 *      2、当对一个对象的改变需要同时改变其它对象, 而不知道具体有多少对象有待改变。 
 *      3、当一个对象必须通知其它对象，而它又不能假定其它对象是谁。换言之, 你不希望这些对象是紧密耦合的。 
 *  
 * 参考："Design Patterns", p293,ISBN:0-201-63361-2
 * 
 * 
 * 解析：===========================================================
 * 
 * Observer 观察者模式又叫 Publish/Subscribe 发布/订阅模式。
 * 
 * 它定义对象间的一种一对多的依赖关系,当一个对象的状态发生改变时, 所有依赖于它的对象都得到通知并被自动更新。
 * 在.Net 中用事件委托 event delegate 来使用 Observer 模式吧。
 *  委托就是一种引用方法的类型。一旦为委托分配了方法，委托将与该方法具有完全相同的行为。
 *  委托方法的使用可以像其他任何方法一样，具有参数和返回值。
 *  委托可以看作是对函数的抽象，是函数的‘类’，委托的实例将代表一个具体的函数。
 * 
 * 一个委托可以搭载多个方法，所有方法依次被唤起。可以使得委托对象所搭载的方法并不需要属于同一个类。
 * 委托对象所搭载的方法必须具有相同的原型和形式，也就是拥有相同的参数列表和返回值类型。 
 * 
 * 观察者模式所做的工作其实就是在解除耦合。让耦合的双方都依赖于抽象，而不是依赖于具体。从而使得各自的变化都不会影响另一边的变化。
 * 依赖倒转原则的最佳体现。
 * 
 * 
 * 
 * 
 * 
 * 
 */
 

namespace DesignPattern.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver(subject, "X"));
            subject.Attach(new ConcreteObserver(subject, "Y"));
            subject.Attach(new ConcreteObserver(subject, "Z"));

            subject.SubjectState = "ABC";
            subject.Notify();

            Console.Read();

        }
    }
}
