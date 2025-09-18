using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingDesignPattern.Creational.Singleton
{
    internal class Logger
    {
        private static Logger? _instance;
        public static readonly object _lock = new object();

        private Logger()
        {
            Console.WriteLine(">> Logger inicializado");
        }

        public static Logger Instance
        {
            get 
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }

                }
                    return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOg]: {message}");
        }

        public void LogDanger(string message)
        {
            Console.WriteLine($"[LOG][DANGER]: {message}");
        }

        public void LogSuccess(string message)
        {
            Console.WriteLine($"[LOG][success]: {message}");
        }
        public void LogInfo(string message)
        {
            Console.WriteLine($"[LOG][info]: {message}");
        }


    }
}
