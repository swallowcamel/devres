namespace SimpleFactory
{
    /// <summary>
    /// 运算类
    /// </summary>
    public abstract class AbstractOperation
    {
        /// <summary>
        /// 数字A
        /// </summary>
        public double NumberA { get; set; } = 0;

        /// <summary>
        /// 数字B
        /// </summary>
        public double NumberB { get; set; } = 0;

        /// <summary>
        /// 得到运算结果
        /// </summary>
        /// <returns></returns>
        public abstract double GetResult();

        /// <summary>
        /// 检查输入的字符串是否准确
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string CheckNumberInput(string currentNumber, string inputString)
        {
            var result = "";
            if (inputString == ".")
            {
                if (currentNumber.IndexOf(".") < 0)
                {
                    if (currentNumber.Length == 0)
                        result = "0" + inputString;
                    else
                        result = currentNumber + inputString;
                }
            }
            else if (currentNumber == "0")
            {
                result = inputString;
            }
            else
            {
                result = currentNumber + inputString;
            }

            return result;
        }
    }
}