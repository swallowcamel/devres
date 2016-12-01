using System;
using System.Collections.Generic;
using System.Text;

/* 
 * =================简单工厂模式 SimpleFactory======================
 * 
 * 意图：用于集中生产对象。
 *  
 * 适用：集中生产实例的情况。
 * 
 *  
 * 注意：
 * ================================================================
 */

namespace SimpleFactory
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入数字A：");
                string strNumberA = Console.ReadLine();
                Console.Write("请选择运算符号(+、-、*、/)：");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B：");
                string strNumberB = Console.ReadLine();
                string strResult = "";

                AbstractOperation oper;
                oper = OperationFactory.CreateOperate(strOperate);
                oper.NumberA = Convert.ToDouble(strNumberA);
                oper.NumberB = Convert.ToDouble(strNumberB);
                strResult = oper.GetResult().ToString();

                Console.WriteLine("结果是：" + strResult);

                Console.ReadLine();


            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有错：" + ex.Message);
            }
        }
    }

 

}

