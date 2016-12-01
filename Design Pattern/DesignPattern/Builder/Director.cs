using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 指挥者类
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}