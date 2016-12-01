using System;

namespace SimpleFactory
{
    /// <summary>
    /// 除法类
    /// </summary>
    internal class OperationDiv : AbstractOperation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("除数不能为0。");
            result = NumberA/NumberB;
            return result;
        }
    }
}