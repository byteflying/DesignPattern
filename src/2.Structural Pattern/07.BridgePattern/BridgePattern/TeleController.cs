using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {

    public class TeleController : TeleControllerBase {

        public override void TurnOff() {
            base.TurnOff();
            Console.WriteLine("-------------------------");
        }

    }

}