using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NapilnikStudyCourse.Chapter2_Logging
{
    class LoggerChain : ILogger
    {
        private ILogger[] _loggers;

        public LoggerChain(params ILogger[] loggers)
        {
            _loggers = loggers;
        }

        public void WriteError(string massage)
        {
            foreach (ILogger e in _loggers)
                e.WriteError(massage);
        }
    }
}
