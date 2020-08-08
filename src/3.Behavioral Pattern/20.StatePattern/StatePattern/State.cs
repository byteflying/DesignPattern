using System;

namespace StatePattern {

    public abstract partial class State {

        public static Water Water { get; set; }

        protected static string StateName { private get; set; }

        public void Increase(int value) {
            if (value == 0) return;
            if (value < 0) throw new ArgumentException();
            OnStateChanging();
            Water.Temperature += value;
            ChangeState();
        }

        public void Reduce(int value) {
            if (value == 0) return;
            if (value < 0) throw new ArgumentException();
            if (Water.Temperature - value <= Const.ABSOLUTE_ZERO) {
                throw new UnReachableException();
            }
            OnStateChanging();
            Water.Temperature -= value;
            ChangeState();
        }

    }

    public abstract partial class State {

        private void ChangeState() {
            if (Water.Temperature <= 0) {
                Water.State = new SolidState();
            }
            else if (Water.Temperature > 0 && Water.Temperature < 100) {
                Water.State = new LiquidState();
            }
            else {
                Water.State = new GasState();
            }
            OnStateChanged();
        }

        protected virtual void OnStateChanging() {
            Console.WriteLine(Const.ON_STATE_CHANGING);
            Console.WriteLine(
                string.Format(Const.TEMPERATURE_INFO,
                              Water.Temperature, StateName));
        }

        protected virtual void OnStateChanged() {
            Console.WriteLine(Const.ON_STATE_CHANGED);
            Console.WriteLine(
                string.Format(Const.TEMPERATURE_INFO,
                              Water.Temperature, StateName));
            Console.WriteLine(Const.LINE_BREAK);
        }

    }

}