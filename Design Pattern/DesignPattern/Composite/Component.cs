using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Composite
{
    /// <summary>
    /// Component为组合中的对象声明接口，在适当的情况下，实现所有类共有接口的默认信息。
    /// 声明一个接口用于访问和管理Component的子部件。
    /// </summary>
    public abstract class Component
    {
         protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}