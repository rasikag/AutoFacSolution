using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_01
{
    internal class Car
    {
        private Engine engine;
        private ILog log;

        public Car(ILog log, Engine engine)
        {
            this.log = log;
            this.engine = engine;
        }

        public void Go()
        {
            engine.Ahead(100);
            log.Write("Engine Start to go forward ...");
        }
    }
}
