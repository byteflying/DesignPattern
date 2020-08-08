using System;
using System.Drawing;

namespace BuilderPattern {

    public class Yuedakia : Builder {

        public override void BuildCarframe() {
            _product.Carframe = "YK9391J0231L30D32";
        }

        public override void BuildWheel() {
            _product.Wheel = 4;
        }

        public override void BuildDoor() {
            _product.Door = 4;
        }

        public override void BuildApparatus() {
            _product.Apparatus = "Kia K3";
        }

        public override void BuildColor() {
            _product.Color = Color.Wheat;
        }

    }

}