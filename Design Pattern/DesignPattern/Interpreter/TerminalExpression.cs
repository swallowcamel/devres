using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
              Console.WriteLine("终端解释器");
        }
    }
}