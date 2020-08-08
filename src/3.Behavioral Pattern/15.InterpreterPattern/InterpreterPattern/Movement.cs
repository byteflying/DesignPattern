using System;
using System.Collections.Generic;

namespace InterpreterPattern {

	public sealed class Movement : IWord {

		private string _movement = String.Empty;

		public Movement(string movement) {
			this._movement = movement;
		}

		private Dictionary<string, string> _movements = new Dictionary<string, string> {
			{"taxing","taxing on the runway"},
			{"takeoff","take off from the runway"},
			{"fly","flying in the sky"},
			{"cruise","navigate a cruise"},
			{"landing","landing on the runway"},
		};

		public string Interpret() {
			return "movement:" + _movements[_movement] + ",";
		}

	}

}