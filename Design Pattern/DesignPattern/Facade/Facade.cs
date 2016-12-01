using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Facade
{
    public class Facade
    {
        private readonly SubSystemOne _subSystemOne;
        private readonly SubSystemTwo _subSystemTwo;
        private readonly SubSystemThree _subSystemThree;
        private readonly SubSystemFour _subSystemFour;

        public Facade()
        {
            _subSystemOne = new SubSystemOne();
            _subSystemTwo = new SubSystemTwo();
            _subSystemThree = new SubSystemThree();
            _subSystemFour = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n方法组A() ---- ");
            _subSystemOne.MethodOne();
            _subSystemTwo.MethodTwo();
            _subSystemFour.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\n方法组B() ---- ");
            _subSystemTwo.MethodTwo();
            _subSystemThree.MethodThree();
        }
    }
}