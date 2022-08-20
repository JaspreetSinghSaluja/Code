using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{

    interface ILogger
    {
        void log(string msg);
    }
    class Logger
    {
        private ILogger _logger;

        public Logger (ILogger logger)
        {
            _logger = logger;
        }

        public void log(string msg)
        {
            _logger.log(msg);
        }
    }

    public class Filelog : ILogger
    {
        public void log(string msg)
        {
            Console.WriteLine("Error Logged in File: " + msg);
        }
    }

    public class DBlog : ILogger
    {
        public void log(string msg)
        {
            Console.WriteLine("Error Logged in Database: " + msg);
        }
    }
}
