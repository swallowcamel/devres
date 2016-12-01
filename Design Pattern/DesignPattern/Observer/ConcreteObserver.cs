using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// 具体观察者
    /// </summary>
    /// <remarks>
    /// 具体观察者角色可以保存一个指向具体主题对象的引用。
    /// 具体观察者角色通常用一个具体子类实现。
    /// </remarks>
    public class ConcreteObserver : Observer
    {

        /// <summary>
        /// 观察者状态
        /// </summary>
        private string _observerState;

        /// <summary>
        /// 名称
        /// </summary>
        private string _name;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.Subject = subject;
            this._name = name;
        }

        /// <summary>
        /// 主题
        /// </summary>
        public ConcreteSubject Subject { get; set; }

        /// <summary>
        /// 更新
        /// </summary>
        public override void Update()
        {
            _observerState = Subject.SubjectState;
            Console.WriteLine($"观察者{_name}新状态是{_observerState}");
        }
    }
}