using System;

namespace CommandPattern {

    public class PrintCommand : Command {

        public PrintCommand(Receiver receiver, CommandArgs commandArgs)
            : base(receiver, commandArgs) {

        }

        public override void Action() {
            _receiver.CommandArgs = _commandArgs;
            (_receiver as PrintReceiver)?.PrintInvoice();
        }

    }

}