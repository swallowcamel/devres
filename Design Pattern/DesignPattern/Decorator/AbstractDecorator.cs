using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Decorator
{
    /// <summary>
    /// AbstractDecorator装饰抽象类，
    /// 继承了AbstractComponent从外类来扩展AbstractComponent的功能，
    /// 但是AbstractComponent却无需知道AbstractDecorator的存在
    /// </summary>
    public abstract class AbstractDecorator : AbstractComponent
    {
       protected AbstractComponent component;

        public void SetComponent(AbstractComponent component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}