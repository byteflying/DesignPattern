using System;

namespace FactoryMethod {

    public class TextFactory : LoggerFactory {

        public override Logger CreateLogger() {
            return new TextLogger();
        }

    }

}