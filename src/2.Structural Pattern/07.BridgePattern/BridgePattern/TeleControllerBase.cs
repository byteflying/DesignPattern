using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {

    public class TeleControllerBase {

        public Television Television { get; set; }

        public virtual void TurnOn() {
            Television.TurnOn();
        }

        public virtual void TurnOff() {
            Television.TurnOff();
        }

        public virtual void TurnChannel() {
            Television.TurnChannel();
        }

    }

}