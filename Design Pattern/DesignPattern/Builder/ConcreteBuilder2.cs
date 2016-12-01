using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 具体建造者类
    /// </summary>
    public class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("部件X");
        }

        public override void BuildPartB()
        {
            _product.Add("部件Y");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}