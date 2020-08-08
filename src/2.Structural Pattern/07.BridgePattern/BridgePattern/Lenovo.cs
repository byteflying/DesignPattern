using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {

    public class Lenovo : Television {

        public override void TurnOn() {
            Console.WriteLine("Turn on Lenovo!");
        }

        public override void TurnOff() {
            Console.WriteLine("Turn off Lenovo!");
        }

        public override void TurnChannel() {
            Console.WriteLine("Turn channel Lenovo!");
        }

    }

}