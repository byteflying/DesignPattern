using System;

namespace InterpreterPattern {

	public sealed class Speed : IWord {

		private double _speed = 0;

		public Speed(double speed) {
			this._speed = speed;
		}

		public string Interpret() {
			return "speed:" + _speed.ToString() + "kn,";
		}

	}

}