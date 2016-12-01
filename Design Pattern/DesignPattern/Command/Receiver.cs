﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{

    /// <summary>
    /// Receiver类，知道如何实施与执行一个与请求相关的操作，任何类都可能作为一个接收者。
    /// </summary>
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("执行请求！");
        }
    }
}