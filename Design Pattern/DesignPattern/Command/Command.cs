using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// Command用来声明执行操作的接口。
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    public abstract class Command
    {
           protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        abstract public void Execute();
    }
}