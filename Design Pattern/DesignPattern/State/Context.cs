using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.State
{
    /// <summary>
    /// 维护一个ConcreteState子类的实例，这个实例定义当前的状态
    /// </summary>
    public class Context
    {
        private State _state;

        /// <summary>
        /// 可读性的状态属性，用于读取当前状态和设置新状态
        /// </summary>
        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("当前状态:" + _state.GetType().Name);
            }
        }

        public Context(State state)
        {
            //定义Context的初始状态
            _state = state;
        }


        public void Request()
        {
            //对请求做处理，并设置下一状态
            _state.Handle(this);
        }
    }
}