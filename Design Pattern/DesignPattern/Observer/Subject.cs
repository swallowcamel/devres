using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Observer
{
    public abstract class Subject
    {
        private IList<Observer> _observers = new List<Observer>();

        /// <summary>
        /// 附加
        /// </summary>
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// 分离
        /// </summary>
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// 通知
        /// </summary>
        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.Update();
            }
        }
    }
}