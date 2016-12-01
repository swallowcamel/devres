using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* 
 * =================职责链模式 Chain Of Responsibility======================
 * 
 * 意图：使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系。
 *      将这个对象连成一条链，并沿着这条链接传递该请求，直到有一个对象处理它为止。
 *  
 * 适用：1、有多个的对象可以处理一个请求，哪个对象处理该请求运行时刻自动确定。 
 *      2、你想在不明确指定接收者的情况下，向多个对象中的一个提交一个请求。 
 *      3、可处理一个请求的对象集合应被动态指定。 
 *  
 * 参考："Design Patterns", p223,ISBN:0-201-63361-2
 * 
 * 好处：1、接收者和发送者都没有对方的明确信息，且链中的对象自己也并不知道链的结构。
 *         结果是职责链可简化对象的相互连接，它们仅需保持一个指向其后继者的引用，
 *         而不需要保持它所有的候选接受者的引用。
 *      2、随时地增加或修改处理一个请求的结构。增强了给对象指派职责的灵活性。
 *      
 * 注意：一个请求极有可能到了链的末端都得不到处理，或者因为没有正确的配置而得不到处理。
 *       
 * ================================================================
 */
namespace DesignPattern.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
             Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

            Console.Read();

        }
    }
}
