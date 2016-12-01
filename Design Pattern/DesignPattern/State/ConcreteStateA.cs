using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.State
{
    /// <summary>
    /// 具体状态，每一个子类实现一个与Context的一个状态相关的行为。
    /// </summary>
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            //设置ConcreteStateA的下一个状态时ConcreteStateB
            context.State = new ConcreteStateB();
        }
    }
}