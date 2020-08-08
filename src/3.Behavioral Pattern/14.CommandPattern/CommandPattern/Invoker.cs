using System;

namespace CommandPattern {

	public class Invoker {

		private Command _command = null;

		public Invoker(Command command) {
			this._command = command;
		}

		public void Execute() {
			_command.Action();
		}

	}

}