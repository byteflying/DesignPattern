using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {

    public class Panasonic : Television {

        public override void TurnOn() {
            Console.WriteLine("Turn on Panasonic!");
        }

        public override void TurnOff() {
            Console.WriteLine("Turn off Panasonic!");
        }

        public override void TurnChannel() {
            Console.WriteLine("Turn channel Panasonic!");
        }

    }

}