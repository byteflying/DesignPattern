using System;

namespace FactoryMethod {

    public static class Extentions {

        public static string LoggerType(this Logger logger) {
            return logger
                .ToString()
                .Replace(nameof(FactoryMethod) + ".", "")
                .Replace(nameof(Logger), "");
        }

    }

}