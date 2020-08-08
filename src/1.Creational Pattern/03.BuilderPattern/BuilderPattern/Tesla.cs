using System;
using System.Drawing;

namespace BuilderPattern {

    public class Tesla : Builder {

        public override void BuildCarframe() {
            _product.Carframe = "ZZ32093M3485C1356";
        }

        public override void BuildWheel() {
            _product.Wheel = 4;
        }

        public override void BuildDoor() {
            _product.Door = 5;
        }

        public override void BuildApparatus() {
            _product.Apparatus = "Model X";
        }

        public override void BuildColor() {
            _product.Color = Color.Red;
        }

    }

}