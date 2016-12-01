namespace SimpleFactory
{
    /// <summary>
    /// º”∑®¿‡
    /// </summary>
    internal class OperationAdd : AbstractOperation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
}