using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _syncRoot = new object();

        //防止外界利用 new 创建对象新实例的可能。
        private Singleton()
        {
        
        }

        public void Show()
        {
            var hashCode = GetHashCode();

            Console.WriteLine($"Singleton Instance Hashcode is {hashCode}");
        }


        /// <summary>
        /// 获取实例，这是获取此类实例的唯一入口
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            /// 双重锁定（Double-Check Locking）,在实例未被创建的时候加锁处理。
            /// 同时也能保证多线程的安全。
            /// 主要用于多线程环境。
            
            if (_instance == null)
            {
                lock (_syncRoot)
                {//同一时刻加了锁的那一部分程序只有一个线程可以进入
                    if (_instance == null)
                    {   /// 这里加第二个判断是如果有两个线程，一个线程通过lock另一个在外排队的情况。
                        /// 里面的线程创建了新实例退出lock，外面等候的线程进入如果不加判断就会创建另外一个实例。
                         _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }
}