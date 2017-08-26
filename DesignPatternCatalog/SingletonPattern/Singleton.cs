using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCatalog.SingletonPattern
{
    public class Singleton
    {
        protected Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }

        private static Singleton instance;
    }
}
