using System;

namespace InterpreterPattern {

	public sealed class Course : IWord {

		private double _course = 0;

		public Course(double course) {
			this._course = course;
		}

		public string Interpret() {
			return $"heading:{_course}°,";
		}

	}

}