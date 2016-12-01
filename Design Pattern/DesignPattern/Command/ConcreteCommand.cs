using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{

    /// <summary>
    /// ConcreteCommand,将一个接收者对象绑定于一个动作，
    /// 调用接收者相应的操作，以实现Execute。
    /// </summary>
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver)
            :
          base(receiver) { }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}