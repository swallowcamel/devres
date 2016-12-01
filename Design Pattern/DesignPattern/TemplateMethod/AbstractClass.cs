using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public abstract class AbstractClass
    {
        /// <summary>
        /// 模板方法给出逻辑骨架，逻辑的组成都是一些相应的抽象操作，这些抽象操作都推迟到子类实现
        /// </summary>
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("模板方法调用完成");
        }

        //一些抽象行为放到子类中去实现

        public abstract void PrimitiveOperation1();

        public abstract void PrimitiveOperation2();
    }
}