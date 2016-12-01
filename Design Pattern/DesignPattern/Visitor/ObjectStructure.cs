using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// 提供一个高层接口以允许访问者访问它的元素。
    /// </summary>
    public class ObjectStructure
    {
        private IList<Element> elements = new List<Element>();

        public void Attach(Element element)
        {
            elements.Add(element);
        }

        public void Detach(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element e in elements)
            {
                e.Accept(visitor);
            }
        }
    }
}