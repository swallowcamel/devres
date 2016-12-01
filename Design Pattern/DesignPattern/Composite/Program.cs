using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =================组合模式 Composite ======================
 *  
 * 意图：将对象组合成树形结构以表示‘部分-整体’的层次结构。
 *      组合模式使得用户对单个对象和组合对象的使用具有一致性。
 *  
 * 适用：1、想表示对象的部分与整体层次的结构时，
 *      2、希望用户可以忽略组合对象与单个对象的不同，统一地所有组合结构中的所有对象时。
 * 
 * 
 * 参考："Design Patterns", p163,ISBN:0-201-63361-2
 * 解析：组合模式的两种实现方式：
 *      1、透明方式：在Component中声明所有用来管理子对象的方法，其中包括Add、Remove等。
 *                 这样实现Component接口的所有子类都具备了Add和Remove。
 *         
 *         好处：叶节点和枝节点对于外界没有区别，它们具有完全一致的行为接口。
 *         问题：Leaf类本身不具备Add（）、Remove（）等方法的功能，所以实现它是没有意义的。
 *         
 *      2、安全方式：在Component中不去声明Add和Remove方法，那么子类的Leaf也就不需要去实现它，而是在Composite声明所有用来管理子类对象的方法。
 *         好处：可以解决透明方式的问题，
 *         问题：由于不够透明，所以树叶和树枝类将不具有相同的接口，客户端的调用需要做相应的判断。
 *      
 *      通常使用 透明方式更简单一些。
 *      
 * 优点： 组合模式让客户可以一致地使用组合结构和单个对象。
 */


namespace DesignPattern.Composite
{
    class Program
    {
        static void Main(string[] args)
        {

            //客户端代码能通过Component接口操作组合部件的对象

            //生成树根root,根上长出两叶LeafA和LeafB
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            //根上长出分支CompositeX,分支上也有两叶LeafXA和LeafXB
            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);

            //在Composite X上再长出分支CompositeXY分支上也有两叶LeafXYA和LeafXYB
            Composite comp2 = new Composite("Composite XY");
            comp2.Add(new Leaf("Leaf XYA"));
            comp2.Add(new Leaf("Leaf XYB"));

            comp.Add(comp2);


            //根上长出两叶LeafC和LeafD，LeafD被移除
            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            //显示树的样子
            root.Display(1);

            Console.Read();
        }
    }
}
