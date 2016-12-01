using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// 发起人
    /// </summary>
    /// <remarks>
    /// 负责创建一个备忘录，用以记录当前时刻它的内部状态，并可以使用备忘录恢复内部状态。
    /// 可根据需要决定Memento存储Originator的哪些内部状态。
    /// </remarks>
    public class Originator
    {
        public string _state;
        public string State {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public void SetMemento(DesignPattern.Memento memento)
        {
            _state = memento.State;
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void Show()
        {
              Console.WriteLine($"State={_state}");
        }
    }
}