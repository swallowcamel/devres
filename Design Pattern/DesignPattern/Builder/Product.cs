using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 产品类，由多个部件组成
    /// </summary>
    public class Product
    {
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n产品 创建 ----");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}