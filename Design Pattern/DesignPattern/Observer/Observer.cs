using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// 为所有的具体观察者定义一个接口，在得到主题的通知时更新自己。
    /// 这个接口叫做更新接口。
    /// 抽象观察者一般用一个抽象类，或者一个接口实现
    /// </summary>
    public abstract class Observer
    {
        /// <summary>
        /// 更新
        /// </summary>
        public abstract void Update();
    }
}