using System;

namespace FactoryMethod {

    public class BinaryFactory : LoggerFactory {

        public override Logger CreateLogger() {
            return new BinaryLogger();
        }

    }

}