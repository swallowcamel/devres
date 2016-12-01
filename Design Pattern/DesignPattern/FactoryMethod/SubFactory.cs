namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// 专门负责生产“-”的工厂
    /// </summary>
    class SubFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}