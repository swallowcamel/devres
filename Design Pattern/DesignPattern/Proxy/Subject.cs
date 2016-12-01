using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// 定义了RealSubject和Proxy的共用接口，这样就在任何使用RealSubject的地方都可以使用Proxy
    /// </summary>
    public abstract class Subject
    {
        public abstract void Request();
    }
}