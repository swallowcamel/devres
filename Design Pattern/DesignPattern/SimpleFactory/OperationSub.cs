namespace SimpleFactory
{
    /// <summary>
    /// ������
    /// </summary>
    internal class OperationSub : AbstractOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
}