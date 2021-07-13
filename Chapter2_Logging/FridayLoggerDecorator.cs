using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NapilnikStudyCourse.Chapter2_Logging
{
    class FridayLoggerDecorator : ILogger
    {
        private ILogger _logger;

        public FridayLoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteError(string massage)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday) _logger.WriteError(massage);
        }
    }
}
