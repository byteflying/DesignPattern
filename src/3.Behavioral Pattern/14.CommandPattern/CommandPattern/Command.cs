using System;

namespace CommandPattern {

	public abstract class Command {

		protected Receiver _receiver = null;

		protected CommandArgs _commandArgs = null;

		public Command(Receiver receiver, CommandArgs commandArgs) {
			this._receiver = receiver;
			this._commandArgs = commandArgs;
		}

		public abstract void Action();

	}

}