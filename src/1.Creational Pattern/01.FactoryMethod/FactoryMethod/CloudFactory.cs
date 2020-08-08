using System;

namespace FactoryMethod {

    public class CloudFactory : LoggerFactory {

        public override Logger CreateLogger() {
            return new CloudLogger();
        }

    }

}