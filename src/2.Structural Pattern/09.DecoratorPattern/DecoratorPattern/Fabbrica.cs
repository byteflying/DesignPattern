using System;

namespace DecoratorPattern {

    public class Fabbrica : Car {

        public Fabbrica() {
            Name = "Fabbrica";
        }

        public override void StartUp() {
            Console.WriteLine($"{Name} is starting!");
        }

    }

}