using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// Element类，定义了一个Accept操作，它以一个访问者为参数
    /// </summary>
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}