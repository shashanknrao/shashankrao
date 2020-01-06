using System;

namespace NinjectNet
{
    class EventLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("{0}: {1}", DateTime.Now, message);
        }
    }
}