using System;

namespace FactoryMethod {

    public class DatabaseFactory : LoggerFactory {

        public override Logger CreateLogger() {
            return new DatabaseLogger();
        }

    }

}