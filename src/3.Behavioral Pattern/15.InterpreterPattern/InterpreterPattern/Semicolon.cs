using System;

namespace InterpreterPattern {

	public sealed class Semicolon : IWord {

		private IWord _left = null;
		private IWord _right = null;

		public Semicolon(IWord left, IWord right) {
			this._left = left;
			this._right = right;
		}

		public string Interpret() {
			return _left.Interpret() + Environment.NewLine + _right.Interpret();
		}

	}

}