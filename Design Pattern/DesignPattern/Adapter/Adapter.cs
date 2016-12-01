using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Adapter
{
    public class Adapter : Target
    {
        private Adaptee _adaptee=new Adaptee();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}