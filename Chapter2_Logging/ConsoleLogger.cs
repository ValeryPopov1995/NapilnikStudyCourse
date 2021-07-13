using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NapilnikStudyCourse.Chapter2_Logging
{
    class ConsoleLogger : ILogger
    {
        public void WriteError(string massage)
        {
            Console.WriteLine(massage);
        }
    }
}
