using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{

    /// <summary>
    /// 定义Proxy所代表的真实实体。
    /// </summary>
    public class RealSubject : Subject
    {
        public override void Request()
        {
             Console.WriteLine("真实的请求");
        }
    }
}