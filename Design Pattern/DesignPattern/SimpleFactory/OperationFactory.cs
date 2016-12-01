namespace SimpleFactory
{
    /// <summary>
    /// 运算类工厂
    /// </summary>
    public class OperationFactory
    {

        public static AbstractOperation CreateOperate(string operate)
        {
            AbstractOperation oper = null;
            switch (operate)
            {
                case "+":
                {
                    oper = new OperationAdd();
                    break;
                }
                case "-":
                {
                    oper = new OperationSub();
                    break;
                }
                case "*":
                {
                    oper = new OperationMul();
                    break;
                }
                case "/":
                {
                    oper = new OperationDiv();
                    break;
                }
                case "sqr":
                {
                    oper = new OperationSqr();
                    break;
                }
                case "sqrt":
                {
                    oper = new OperationSqrt();
                    break;
                }
                case "+/-":
                {
                    oper = new OperationReverse();
                    break;
                }
            }

            return oper;
        }
    }
}