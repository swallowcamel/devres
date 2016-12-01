using System;

/* 
 * =================工厂方法模式 FactoryMethod======================
 * 
 * 定义：定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法使一个类的实例化延迟到其子类。[DP]
 *  
 * 适用：当一个类不知道它所必须创建的对象的类的时候。 
 *      当一个类希望由它的子类来指定它所创建的对象的时候。 
 *      当类将创建对象的职责委托给多个帮助子类中的某一个，并且你希望将哪一个帮助子类是代理者这一信息局部化的时候。 
 *  
 * 参考："Design Patterns", p107,ISBN:0-201-63361-2
 * 
 * 简单工厂 vs 工厂方法
 * 
 * 简单工厂模式的最大优点在于工厂类中包含了必要的逻辑判定，
 * 根据客户端的选择条件动态实例化相关的类，对于客户端来说，去除了于具体产品的依赖。
 * 工厂方法模式实现时，客户端需要决定实例化哪一个工厂来实现运算类，选择判断的问题还是存在的，
 * 也就是说，工厂方法吧简单工厂的内部逻辑判断移动到了客户端代码来进行。
 * 你想要加功能，本来是改工厂类的，现在是改客户端。
 * 
 * 
 * 
 * ================================================================
 */

namespace DesignPattern.FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IFactory operFactory = new AddFactory();
            var oper = operFactory.CreateOperation();
            oper.NumberA = 1;
            oper.NumberB = 2;
            var result = oper.GetResult();

            Console.WriteLine(result);

            Console.Read();
        }
    }
}