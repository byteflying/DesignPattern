using System;

namespace FactoryMethod {

    public class DatabaseLogger : Logger {

        public override void Log(string message) {
            Console.WriteLine($"INFO {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff")}" +
                $" [{this.LoggerType()}] {message}");
        }

    }

}