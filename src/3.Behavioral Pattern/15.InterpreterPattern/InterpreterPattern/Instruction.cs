using System;

namespace InterpreterPattern {

	public sealed class Instruction : IWord {

		private IWord _course = null;
		private IWord _speed = null;
		private IWord _movement = null;
		private IWord _voyage = null;

		public Instruction(IWord course, IWord speed, IWord movement, IWord voyage) {
			this._course = course;
			this._speed = speed;
			this._movement = movement;
			this._voyage = voyage;
		}

		public string Interpret() {
			return _course.Interpret() +
						  _speed.Interpret() +
						  _movement.Interpret() +
						  _voyage.Interpret();
		}

	}

}