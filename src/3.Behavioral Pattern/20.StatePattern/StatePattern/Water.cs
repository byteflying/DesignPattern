using System;

namespace StatePattern {

    public class Water {

        public State State { get; set; }

        public double Temperature { get; set; } = 0;

        public Water() {
            State = new SolidState();
            State.Water = this;
        }

        public Water Increase(int value) {
            State.Increase(value);
            return this;
        }

        public Water Reduce(int value) {
            State.Reduce(value);
            return this;
        }

        public Water Drink() {
            if (this.State is LiquidState) {
                Console.WriteLine("You can drink!");
            }
            else {
                Console.WriteLine("You can not drink!");
            }
            Console.WriteLine(Const.LINE_BREAK);
            return this;
        }

    }

}