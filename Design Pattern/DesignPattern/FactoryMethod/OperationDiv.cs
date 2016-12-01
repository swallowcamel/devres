using System;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// ������
    /// </summary>
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("��������Ϊ0��");
            result = NumberA / NumberB;
            return result;
        }
    }
}