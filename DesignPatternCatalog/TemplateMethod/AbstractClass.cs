using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCatalog.TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            //todo
            PrimitiveOperation1();
            //todo
            PrimitiveOperation2();
            //todo
        }

        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
    }
}
