using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternCatalog.DecoratorPattern
{
    public class Decorator : Component
    {
        public override void Operation()
        {
            component.Operation();
        }

        private Component component;
    }
}
