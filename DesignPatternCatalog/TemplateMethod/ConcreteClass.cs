using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCatalog.TemplateMethod
{
    public class ConcreteClass : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            throw new NotImplementedException();
        }

        public override void PrimitiveOperation2()
        {
            throw new NotImplementedException();
        }
    }
}
