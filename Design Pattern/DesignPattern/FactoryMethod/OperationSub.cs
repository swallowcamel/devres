﻿namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// 减法类
    /// </summary>
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
}