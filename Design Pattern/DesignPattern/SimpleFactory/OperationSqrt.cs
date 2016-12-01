using System;

namespace SimpleFactory
{
    /// <summary>
    /// 平方根类
    /// </summary>
    internal class OperationSqrt : AbstractOperation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB < 0)
                throw new Exception("负数不能开平方根。");
            result = Math.Sqrt(NumberB);
            return result;
        }
    }
}