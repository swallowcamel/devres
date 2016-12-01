using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.State
{
    /// <summary>
    /// 抽象状态类,定义一个接口以封装于Context的一个特定状态相关的行为
    /// </summary>
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}