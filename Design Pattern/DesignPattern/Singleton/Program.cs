using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * =================单例模式 Singleton======================
 * 
 * 意图：保证一个类仅有一个实例，并提供一个访问它的全局访问点。
 *  
 * 适用：
 *  
 * 参考："Design Patterns", p107,ISBN:0-201-63361-2
 * 
 * 好处： 1、保证一个类仅有一个唯一实例。
 *       2、单例模式因为Singleton类封装它的唯一实例，
 *       这样它可以严格地控制客户怎样访问它及何时访问它。简单地说就是对唯一实例的受控访问。
 *       
 * 与实用类静态方法的区别：
 *      1、实用类不用保存状态，单例是有状态的。
 *      2、实用类不能用于继承多态，单例可以由子类来继承。
 *      3、实用类只不过是一些方法属性的集合，而单例有唯一对象实例。
 *      
 *      在实际操作中用哪种方式需要具体分析。
 *      
 * 多线程时的单例：
 *      1、通过进程锁双重锁定来处理。
 *         lock：确保当一个线程位于代码的临界区时，另一个线程不进入临界区。
 *               如果其它线程试图进入锁定的代码，则它将一直等待（被阻止），直到该对象被释放。 *      
 *      
 *      2、静态初始化
 *      DEMO：
 *      private static readonly instance=new Singleton();
 *      private Singleton(){
 *      }
 *      public Singleton GetInstance(){
 *          return instance;
 *      }
 *      
 *      
 *      两种单例模式的区别：
 *          1、静态初始化方式，是在类初始化时就实例化，需要提前占用系统资源。
 *          2、懒加载方式，是在第一次被引用时才实例化，会面临多线程的问题，需要双重锁定才能解决。     
 *     
 *          C# 实际操作中用 静态初始化方式就足够了。
 *      
 *      
 *       
 * ================================================================
 */

namespace DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleInstance1 = Singleton.GetInstance();
            singleInstance1.Show();
            
            var singleInstance2 = Singleton.GetInstance();
            singleInstance2.Show();

            var singleInstance3 = Singleton.GetInstance();
            singleInstance3.Show();


            Console.Read();
        }
    }
}
