using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// 具体主题/具体通知者
    /// </summary>
    /// <remarks>
    /// 将有关状态存入具体观察者对象；
    /// 在具体主题的内部状态改变时，给所有登记过的观察者发出通知。
    /// 具体主题角色通常用一个具体子类实现。
    /// </remarks>
    public class ConcreteSubject : Subject
    {
        /// <summary>
        /// 具体通知者状态
        /// </summary>
        public string SubjectState { get; set; }
    }
}