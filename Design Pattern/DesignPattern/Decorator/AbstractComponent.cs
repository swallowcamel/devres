using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Decorator
{
    /// <summary>
    /// AbstractComponent 是定义一个对象接口，可以给这些对象动态的添加职责
    /// </summary>
    public abstract class AbstractComponent
    {
        public abstract void Operation();
    }
}