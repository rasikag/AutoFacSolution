using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var log = new ConsoleLog();
            var engine = new Engine(log);
            var car = new Car(engine,log);
            car.Go();
        }
    }
}
