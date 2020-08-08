using System;

namespace CommandPattern {

	public class CancelCommand : Command {

		public CancelCommand(Receiver receiver, CommandArgs commandArgs)
			: base(receiver, commandArgs) {

		}

		public override void Action() {
			_receiver.CommandArgs = _commandArgs;
			(_receiver as CancelReceiver)?.CancelInvoice();
		}

	}

}