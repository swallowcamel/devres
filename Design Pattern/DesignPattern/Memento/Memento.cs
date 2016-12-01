using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// 备忘录
    /// </summary>
    /// <remarks>
    /// 负责存储Originator对象的内部状态，并可以防止Originator以外的其它对象访问备忘录Memento。
    /// 备忘录有2个接口，Caretaker只能看到备忘录的窄接口，它只能将备忘录传递给其它睡醒。
    /// Originator能够看到一个宽接口，允许它访问返回到先前状态所需的所有数据。
    /// </remarks>
    public class Memento
    {
        private string _state;

        public string State
        {
            get { return _state; }
        }

        public Memento(string state)
        {
            this._state = state;
        }
    }
}