using System;
using System.Collections.Generic;
using System.Drawing;

namespace BuilderPattern {

    public class Vehicle {

        public string Carframe { get; set; }

        public int Wheel { get; set; }

        public int Door { get; set; }

        public string Apparatus { get; set; }

        public Color Color { get; set; }

        public void Print() {
            Console.WriteLine($"{this.VehicleInfo()}");
        }

    }

}