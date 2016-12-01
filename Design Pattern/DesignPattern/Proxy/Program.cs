using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* 
 * =====================代理模式 Proxy=========================
 * 
 * 定义：为其他对象提供一种代理以控制对这个对象的访问。[DP]
 *  
 * 适用：1、远程代理，也就是为一个对象在不同的地址空间提供局部代表。这样可以隐藏一个对象存在于不同地址空间的事实。
 *      2、虚拟代理，是根据需要创建开销很大的对象。通过它来存放实例化需要很长时间的真实对象。
 *      3、安全代理，用来控制真实对象访问时的权限。
 *      4、智能指引，是指当调用真实的对象时，代理处理另外一些事。     
 *      
 * 
 * 参考："Design Patterns", p207,ISBN:0-201-63361-2
 
 * 注意：
 * 
 * 
 * 
 */
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();

            Console.ReadLine();
        }
    }
}
