namespace SimpleFactory
{
    /// <summary>
    /// ∆Ω∑Ω¿‡
    /// </summary>
    internal class OperationSqr : AbstractOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberB*NumberB;
            return result;
        }
    }
}