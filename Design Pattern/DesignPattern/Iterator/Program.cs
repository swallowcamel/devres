using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =================迭代器模式 Iterator ======================
 *  
 * 意图：提供一种顺序访问一个聚合对象中各个元素，而又不暴露该对象内部的内部表示。
 *  
 * 适用：1、访问一个聚合对象的内容而无需暴露它的内部表示。 
 *      2、支持对聚合对象的多种遍历。 
 *      3、为遍历不同的聚合结构提供一个统一的接口(支持多态迭代)。 
 *  
 * 参考："Design Patterns", p257,ISBN:0-201-63361-2
 * 
 * 解析：迭代器模式就是分离了集合对象的遍历行为，抽象出一个迭代器类来负责，
 *      这样既可以做到不暴露集合的内部结构，又可以让外部代码透明地访问集合内部的数据。
 * 
 * PS： 在C#语言中已经实现了此模式，
 * IEnumerator支持对非泛型集合的简单迭代接口。
 * IEnumerable公开枚举数，该枚举数支持在非泛型集合上进行简单迭代。
 * 
 * 以上都有泛型接口IEnumerator<T>和IEnumerable<T>
 * 
 * 还有：
 * foreach(string item in list){
 *  //do something
 * }
 * 
 * 编译器里是这样实现的：
 * IEnumerator<string> e=a.GetEnumerator();
 * while(e.MoveNext()){
 *  //do something
 * }
 * 
 */
 


namespace DesignPattern.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
             ConcreteAggregate a = new ConcreteAggregate();

            a[0] = "大鸟";
            a[1] = "小菜";
            a[2] = "行李";
            a[3] = "老外";
            a[4] = "公交内部员工";
            a[5] = "小偷";

            Iterator i = new ConcreteIterator(a);
            //Iterator i = new ConcreteIteratorDesc(a);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine("{0} 请买车票!", i.CurrentItem());
                i.Next();
            }

            Console.Read();
        }
    }
}
