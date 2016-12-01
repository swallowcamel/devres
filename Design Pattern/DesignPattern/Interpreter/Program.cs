using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/* 
 * =================解释器模式 Interpreter ======================
 *  
 * 意图：给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语言中的句子。
 *  
 * 适用：当有一个语言需要解释执行, 并且你可将该语言中的句子表示为一个抽象语法树时，可使用解释器模式。
 *      而当存在以下情况时该模式效果最好： 
 *          1、该文法简单对于复杂的文法, 文法的类层次变得庞大而无法管理。此时语法分析程序生成器这样的工具是更好的选择。
 *             它们无需构建抽象语法树即可解释表达式, 这样可以节省空间而且还可能节省时间。 
 *             
 *          2、效率不是一个关键问题最高效的解释器通常不是通过直接解释语法分析树实现的, 而是首先将它们转换成另一种形式。
 *             例如，正则表达式通常被转换成状态机。但即使在这种情况下, 转换器仍可用解释器模式实现, 该模式仍是有用的。 
 *  
 * 参考："Design Patterns", p243,ISBN:0-201-63361-2
 * 
 * 优点：容易地改变和扩展文法，因为该模式使用类来表示文法规则，可以使用继承来改变或扩展文法。
 *      也比较容易实现文法，因为定义抽象语法树中各个节点的类的实现大体类似，这些类都易于直接编写。
 * 
 * 不足：解释器模式为文法中的每一条规则至少定义了一个类，因此包含许多规则的文法可能难以管理和维护。
 *      当文法非常复杂时，使用其它的技术：如语法分析程序或编译器生成器来处理。
 *      
 * 
 */
namespace  DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
              Context context = new Context();
            IList<AbstractExpression> list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            Console.Read();
        }
    }
}
