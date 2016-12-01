using System;

namespace SimpleFactory
{
    /// <summary>
    /// ƽ������
    /// </summary>
    internal class OperationSqrt : AbstractOperation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB < 0)
                throw new Exception("�������ܿ�ƽ������");
            result = Math.Sqrt(NumberB);
            return result;
        }
    }
}