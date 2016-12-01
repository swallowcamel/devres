using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// 保存一个引用使得代理可以访问实体，并提供一个与Subject的接口相同的接口，
    /// 这样代理就可以用来替代实体。
    /// </summary>
    public class Proxy : Subject
    {
        private RealSubject realSubject;

        public override void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }

            realSubject.Request();
        }
    }
}