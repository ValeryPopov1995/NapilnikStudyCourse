using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NapilnikStudyCourse.Chapter2_Logging
{
    class Pathfinder
    {
        ILogger _logger;

        public Pathfinder(ILogger logger)
        {
            _logger = logger;
        }

        public void Find(string massage)
        {
            _logger.WriteError(massage);
        }
    }
}
