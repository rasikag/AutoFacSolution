using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_01
{
    class PreviousCode
    {
        //builder.RegisterType<ConsoleLog>().As<ILog>();
        //builder.RegisterType<Engine>();
        //builder.RegisterType<Car>();

        // in unit testing 
        //var log = new ConsoleLog();
        //builder.RegisterInstance(log).As<ILog>();


        //builder.RegisterType<Car>()
        //    .UsingConstructor(typeof(Engine));

        //builder.Register((IComponentContext c) =>
        //        new Engine(c.Resolve<ILog>(), 123));

        //builder.RegisterType<Car>();

        //var car = container.Resolve<Car>();
        //car.Go();
    }
}
