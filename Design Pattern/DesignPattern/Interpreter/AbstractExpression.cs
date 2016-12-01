using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}