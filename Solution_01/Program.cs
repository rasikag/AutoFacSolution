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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
