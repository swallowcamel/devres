using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Mediator
{

    /// <summary>
    /// 抽象同事
    /// 每个具体同事只知道自己的行为，而不了解其它同事类的情况，但它们却都认识中介者对象。
    /// Mediator是抽象中介者，定义了同事对象到中介者对象的接口， ConcreteMediator是具体中介者对象，
    /// 实现抽象类的方法，它需要知道所有具体同事类， 并从具体同事接收消息，向具体同事发出命令。
    /// </summary>
    public abstract class Colleague
    {
       protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}