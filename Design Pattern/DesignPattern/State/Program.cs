using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =================状态模式 State ======================
 *  
 * 定义：当一个对象的内在状态改变时允许改变其行为，这个对象看起来像是改变了其类[DP]。 
 *   
 *   状态模式主要解决的是当控制一个对象状态转换的条件表达式过于复杂时的情况。
 *   把状态判断的逻辑转移到表示不同状态的一系列类当中，可以把复杂的判断逻辑简化。
 *  
 * 适用：1、一个对象的行为取决于它的状态, 并且它必须在运行时刻根据状态改变它的行为。 
 *      2、一个操作中含有庞大的多分支的条件语句，且这些分支依赖于该对象的状态。
 *        这个状态通常用一个或多个枚举常量表示。通常, 有多个操作包含这一相同的条件结构。
 *        State模式将每一个条件分支放入一个独立的类中。
 *        这使得你可以根据对象自身的情况将对象的状态作为一个对象，这一对象可以不依赖于其他对象而独立变化。  
 *  
 *  
 * 参考："Design Patterns", p305,ISBN:0-201-63361-2
 * 
 * 好处：1、将与特定状态相关的行为局部化，并且将不同状态的行为分割开来。
 *      （将特定的状态相关的行为都放入一个对象中，由于所有与状态相关的代码都存在于某个ConcreteState中，
 *        所以通过定义新的子类可以很容易的增加新的状态和转换。）
 *      2、状态模式通过把各种状态转移逻辑分布到State子类之间，来减少相互间的依赖。
 *      
 * PS： 状态判断简单的情况就没必要用这招了。
 * 面向对象设计其实就是希望做到代码的责任分解。如果方法过长，而且有很多判断分支。就意味着它的责任过大，违背‘单一职责原则’。
 * 
 * 
 */
 

namespace  DesignPattern.State
{
    class Program
    {
        static void Main(string[] args)
        {
            //设置Context的初始状态为ConcreteStateA
            Context context = new Context(new ConcreteStateA());
            
            //不断的请求，同时不断的更改状态

            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.Read();
        }
    }
}
