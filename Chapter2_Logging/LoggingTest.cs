using NUnit.Framework;

namespace NapilnikStudyCourse.Chapter2_Logging
{
    class Tests
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
