using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.State
{
    /// <summary>
    /// 具体状态，每一个子类实现一个与Context的一个状态相关的行为。
    /// </summary>
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            //设置ConcreteStateB的下一个状态时ConcreteStateA
            context.State = new ConcreteStateA();
        }
    }
}