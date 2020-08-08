using System;

namespace DecoratorPattern {

    public class Paster : CoolCar {

        public Paster(Car car) : base(car) {

        }

        public override void StartUp() {
            SetPaster();
            base.StartUp();
        }

        private void SetPaster() {
            Console.WriteLine($"Set paster to {_car.Name}!");
        }

    }

}