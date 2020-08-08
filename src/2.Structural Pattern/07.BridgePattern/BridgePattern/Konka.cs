using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {

    public class Konka : Television {

        public override void TurnOn() {
            Console.WriteLine("Turn on Konka!");
        }

        public override void TurnOff() {
            Console.WriteLine("Turn off Konka!");
        }

        public override void TurnChannel() {
            Console.WriteLine("Turn channel Konka!");
        }

    }

}