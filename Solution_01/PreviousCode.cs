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
        //builder.RegisterGeneric(typeof(List<>)).As(typeof(IList<>));

        //IContainer container = builder.Build();

        //var myList = container.Resolve<IList<int>>();
        //Console.WriteLine(myList.GetType().Name);

        // named parameter
        //builder.RegisterType<SMSLog>().As<ILog>()
        //        .WithParameter("phoneNumber", "+123455678");

        //// typed parameter 
        //builder.RegisterType<SMSLog>()
        //        .As<ILog>()
        //        .WithParameter(new TypedParameter(typeof(string), "+123456789"));

        //    // resolved parameter 
        //    builder.RegisterType<SMSLog>()
        //        .As<ILog>()
        //        .WithParameter(
        //            new ResolvedParameter(
        //                // predicate
        //                (pi, ctx) => pi.ParameterType == typeof(string) && pi.Name == "phoneNumber",
        //                // value accessor
        //                (pi, ctx) => "+1234567890"
        //            )
        //        );

        //    var container = builder.Build();
        //var log = container.Resolve<ILog>();

        //log.Write("Test message");
    }
}
