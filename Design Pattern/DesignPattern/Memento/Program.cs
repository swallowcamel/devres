using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =================备忘录模式 Memento ======================
 *  
 * 意图：在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样以后就可将该对象恢复到原先保存的状态。
 *  
 * 适用：1、必须保存一个对象在某一个时刻的(部分)状态, 这样以后需要时它才能恢复到先前的状态。 
 *      2、如果一个用接口来让其它对象直接得到这些状态，将会暴露对象的实现细节并破坏对象的封装性。 
 *  
 * 参考："Design Patterns", p283,ISBN:0-201-63361-2
 * 
 * 解析： 
 */
 

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
             Originator o = new Originator();
            o.State = "On";
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";
            o.Show();

            o.SetMemento(c.Memento);
            o.Show();

            Console.Read();
        }
    }
}
