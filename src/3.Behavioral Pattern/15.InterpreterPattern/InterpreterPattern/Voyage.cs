using System;

namespace InterpreterPattern {

	public sealed class Voyage : IWord {

		private double _voyage = 0;

		public Voyage(double voyage) {
			this._voyage = voyage;
		}

		public string Interpret() {
			return "voyage:" + _voyage.ToString() + "km.";
		}

	}

}