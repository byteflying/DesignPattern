using System;

namespace DecoratorPattern {

    public class Maserati : Car {

        public Maserati() {
            Name = "Maserati";
        }

        public override void StartUp() {
            Console.WriteLine($"{Name} is starting!");
        }

    }

}