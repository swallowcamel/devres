using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// 享元工厂，用来管理并创建Flyweight对象。
    /// 用来确保合理地共享Flyweight，当用户请求一个Flyweight时，
    /// FlyweightFactory对象提供一个已创建的实例或者创建一个（不存在就创建）
    /// </summary>
    public class FlyweightFactory
    {
         private Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());

        }

        public Flyweight GetFlyweight(string key)
        {
            return ((Flyweight)flyweights[key]);
        }
    }
}