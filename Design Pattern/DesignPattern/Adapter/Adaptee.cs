﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Adapter
{
    public class Adaptee
    {

        public void SpecificRequest()
        {
             Console.WriteLine("特殊请求");
        }
    }
}