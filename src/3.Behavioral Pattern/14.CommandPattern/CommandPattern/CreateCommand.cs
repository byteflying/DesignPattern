using System;

namespace CommandPattern {

	public class CreateCommand : Command {

		public CreateCommand(Receiver receiver, CommandArgs commandArgs)
			: base(receiver, commandArgs) {

		}

		public override void Action() {
			_receiver.CommandArgs = _commandArgs;
            (_receiver as CreateReceiver)?.CreateInvoice();
		}

	}

}