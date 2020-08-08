using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {

    public abstract class Car {

        public string Name { get; set; }

        public abstract void StartUp();

    }

}