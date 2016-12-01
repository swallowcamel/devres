using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =================命令模式 Command ======================
 *  
 * 意图：将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；
 *      对请求排队或记录请求日志，以及支持可撤销的操作。
 *  
 * 适用：
 *  
 * 参考："Design Patterns", p233,ISBN:0-201-63361-2
 * 
 * 优点：1、能较容易地设计一个命令队列；
 *      2、在需要的情况下，可以较容易地将命令记入日志
 *      3、允许接收请求的一方决定是否要否决请求
 *      4、可以容易地实现对请求的撤销和重做
 *      5、由于加进新的具体命令类不影响其它的类，因此增加新的具体命令类很容易。
 *      
 *      关键优点：命令模式把请求一个操作的对象与知道怎么执行一个操作的对象分割开。
 * 
 * 是否碰到类似情况就一定要实现命令模式呢？
 * 
 * 敏捷开发原则告诉我们，不要为代码添加基于猜测的，实际不需要的功能。
 * 如果不清楚一个系统是否需要命令模式，一般就不要着急去实现它，
 * 事实上，在需要的时候通过重构实现这个模式并不困难，只有在真正需要的时候把原来的代码重构为命令模式才有意义。
 * 
 * 
 */
 


namespace DesignPattern
{
    /// <summary>
    /// 客户端代码，创建一个具体命令对象并设定它的接收者。
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            Invoker i = new Invoker();

            // Set and execute command 
            i.SetCommand(c);
            i.ExecuteCommand();

            Console.Read();
        }
    }
}
