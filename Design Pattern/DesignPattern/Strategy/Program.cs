using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =================策略模式 Strategy======================
 * 
 * 定义：它定义了算法家族，分别封装起来，让它们之间可以互相替换，此模式让算法的变化，不会影响到使用算法的客户[DP]。
 *  
 * 适用：1、许多相关的类仅仅是行为有异。“策略”提供了一种用多个行为中的一个行为来配置一个类的方法。 
 *      2、需要使用一个算法的不同变体。例如，你可能会定义一些反映不同的空间/时间权衡的算法。当这些变体实现为一个算法的类层次时[HO87] ,可以使用策略模式。 
 *      3、算法使用客户不应该知道的数据。可使用策略模式以避免暴露复杂的、与算法相关的数据结构。 
 *      4、一个类定义了多种行为, 并且这些行为在这个类的操作中以多个条件语句的形式出现。将相关的条件分支移入它们各自的Strategy类中以代替这些条件语句。 
 *  
 * 参考："Design Patterns", p315,ISBN:0-201-63361-2
 * 
 * 解析： 
 */


namespace DesignPattern.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            //与简单工厂整合的调用方式
            //================================
            context = new Context("StrategyA");
            context.ContextInterface();
            context = new Context("StrategyB");
            context.ContextInterface();
            context = new Context("StrategyC");
            context.ContextInterface();



            Console.Read();
        }
    }



    
}
