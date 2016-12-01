using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Composite
{

    /// <summary>
    /// Leaf在组合中表示叶节点对象，叶节点没有子节点。
    /// </summary>
    public class Leaf:Component
    {
         public Leaf(string name)
            : base(name)
        { }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}