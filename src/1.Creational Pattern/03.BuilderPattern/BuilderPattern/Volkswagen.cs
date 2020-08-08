using System;
using System.Drawing;

namespace BuilderPattern {

    public class Volkswagen : Builder {

        public override void BuildCarframe() {
            _product.Carframe = "VS89362P1903C9852";
        }

        public override void BuildWheel() {
            _product.Wheel = 4;
        }

        public override void BuildDoor() {
            _product.Door = 4;
        }

        public override void BuildApparatus() {
            _product.Apparatus = "Skoda";
        }

        public override void BuildColor() {
            _product.Color = Color.Blue;
        }

    }

}