using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternCatalog.Adapter
{
    public class Adapter : Target
    {
        private Adaptee adaptee;
    
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
