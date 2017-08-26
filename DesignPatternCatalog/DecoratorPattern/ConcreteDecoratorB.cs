using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternCatalog.DecoratorPattern
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        public void AddedBehavior()
        {
            //todo
        }
    }
}
