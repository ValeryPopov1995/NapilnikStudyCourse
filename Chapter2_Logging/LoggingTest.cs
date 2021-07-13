using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace NapilnikStudyCourse.Chapter2_Logging
{
    [TestFixture]
    class LoggingTest
    {
        [Test]
        public void UseCase()
        {
            var ConsoleFinder = new Pathfinder(new ConsoleLogger());
            var FileFinder = new Pathfinder(new FileLogger());
            var ConsoleFridayFinder = new Pathfinder(new FridayLoggerDecorator(new ConsoleLogger()));
            var FileFridayFinder = new Pathfinder(new FridayLoggerDecorator(new FileLogger()));
            var ChainFinder = new Pathfinder(new LoggerChain(new ConsoleLogger(), new FridayLoggerDecorator(new FileLogger())));
        }
    }
}
