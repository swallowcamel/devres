namespace SimpleFactory
{
    /// <summary>
    /// �෴����
    /// </summary>
    internal class OperationReverse : AbstractOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = -NumberB;
            return result;
        }
    }
}