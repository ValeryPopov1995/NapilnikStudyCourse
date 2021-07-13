using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NapilnikStudyCourse.Chapter2_Logging
{
    class FileLogger : ILogger
    {
        public void WriteError(string massage)
        {
            File.WriteAllText("log.txt", massage);
        }
    }
}
