using System.Collections.Generic;
using System.Text;




namespace DesignPattern.FactoryMethod
{

    /// <summary>
    /// 运算类
    /// </summary>
    abstract class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        /// <summary>
        /// 得到运算结果
        /// </summary>
        /// <returns></returns>
        public abstract double GetResult();
    }
}
