using System;

namespace FactoryMethod {

    public class Program {

        private static LoggerFactory _factory = null;
        private static Logger _logger = null;

        public static void Main(string[] args) {
            _factory = new TextFactory();
            CreateLogger();

            _factory = new BinaryFactory();
            CreateLogger();

            _factory = new DatabaseFactory();
            CreateLogger();

            _factory = new CloudFactory();
            CreateLogger();

            Console.ReadKey();
        }

        const string LOG_MESSAGE = "I logged a lot of {0} info!";

        private static void CreateLogger() {
            _logger = _factory.CreateLogger();
            _logger.Log(string.Format(LOG_MESSAGE, _logger.LoggerType()));
        }

    }

}