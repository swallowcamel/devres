using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Composite
{

    /// <summary>
    /// Composite 定义有枝节点行为，用来存储子部件，在Composite接口中实现与子部件有关的操作，比如增加Add和删除Remove
    /// </summary>
    public class Composite:Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name)
            : base(name)
        { }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}