using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Solution_01
{
    public interface ILog
    {
        void Write(string message);
    }

    public class ConsoleLog : ILog
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class EmailLog : ILog
    {
        private const string AdminEmail = "rasikag@hp.com";

        public void Write(string message)
        {
            Console.WriteLine($"I got the email from {AdminEmail} called as {message}");
        }
    }

    public class Engine
    {
        private ILog log;
        private int id;
        public Engine(ILog log)
        {
            this.log = log;
            id = new Random().Next();
        }

        public void Ahead(int power)
        {
            log.Write($"Engine [{id}] ahead {power}");
        }

    }

    public class Car
    {
        private Engine Engine;
        private ILog log;

        public Car(Engine engine, ILog log)
        {
            this.log = log;
            this.Engine = engine;
        }

        public void Go()
        {
            Engine.Ahead(100);
            log.Write("Car go forward...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleLog>().As<ILog>().AsSelf();
            builder.RegisterType<Engine>();
            builder.RegisterType<Car>();

            IContainer container = builder.Build();

            var car = container.Resolve<Car>();
            car.Go();

        }
    }
}
