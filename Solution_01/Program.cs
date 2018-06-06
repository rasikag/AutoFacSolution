using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;

namespace Solution_01
{
    public interface ILog
    {
        void Write(string message);
    }

    public interface IConsole
    {

    }

    public class ConsoleLog : ILog, IConsole
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

        public Engine(ILog log, int v)
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

        public Car(Engine engine)
        {
            this.log = new EmailLog();
            this.Engine = engine;
        }

        public void Go()
        {
            Engine.Ahead(100);
            log.Write("Car go forward...");
        }
    }

    public class SMSLog : ILog
    {
        private string PhoneNumber;

        public SMSLog(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public void Write(string message)
        {
            Console.WriteLine($"SMS to {PhoneNumber} : {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            var builder = new ContainerBuilder();

            Random random = new Random();
            builder.Register((c, p) => new SMSLog(p.Named<string>("phoneNumber")))
                .As<ILog>();

            var container = builder.Build();
            var log = container.Resolve<ILog>(new NamedParameter("phoneNumber",
                        random.Next()));

            Console.ReadLine();
        }
    }
}
