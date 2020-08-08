using System;

namespace DecoratorPattern {

    public class Visor : CoolCar {

        public Visor(Car car) : base(car) {

        }

        public override void StartUp() {
            SetVisor();
            base.StartUp();
        }

        private void SetVisor() {
            Console.WriteLine($"Set visor to {_car.Name}!");
        }

    }

}