﻿using System;

namespace FactoryMethod {

    public class BinaryLogger : Logger {

        public override void Log(string message) {
            Console.WriteLine($"INFO {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff")}" +
                $" [{this.LoggerType()}] {message}");
        }

    }

}