using System;

namespace BuilderPattern {

    public abstract class Builder {

        protected Vehicle _product = new Vehicle();

        public abstract void BuildCarframe();

        public abstract void BuildWheel();

        public abstract void BuildDoor();

        public abstract void BuildApparatus();

        public abstract void BuildColor();

        public virtual Vehicle GetResult() {
            return _product;
        }

    }

}