using System;

namespace BuilderPattern {

    public class Director {

        public void Construct(Builder builder) {
            builder.BuildCarframe();
            builder.BuildWheel();
            builder.BuildDoor();
            builder.BuildApparatus();
            builder.BuildColor();
        }

    }

}