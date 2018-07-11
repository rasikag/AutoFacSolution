using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_02
{
    internal class Example02
    {
        public void Execute()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmailLog>().As<ILog>().As<IConsole>();
            builder.RegisterType<ConsoleLog>().As<ILog>().PreserveExistingDefaults();
            builder.RegisterType<Engine>();
            builder.RegisterType<Car>();

            IContainer container = builder.Build();

            var car = container.Resolve<Car>();

            
            car.Go();
            Console.ReadLine();
        }
    }
}
