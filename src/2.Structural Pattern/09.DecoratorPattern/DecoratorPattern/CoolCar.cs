using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {

    public abstract class CoolCar : Car {

        protected Car _car = null;

        public CoolCar(Car car) {
            _car = car;
        }

        public override void StartUp() {
            Console.WriteLine($"{_car.Name} is starting!");
        }

    }

}