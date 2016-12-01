using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// 管理者
    /// </summary>
    /// <remarks>
    /// 负责保存好备忘录Memento，不能对备忘录的内容进行操作或检查。
    /// </remarks>
    public class Caretaker
    {
        public Memento Memento { get; set; }
    }
}