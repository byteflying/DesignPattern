using System;

namespace VistorPattern {

	public class Kris : Student {

		public Kris(string name) : base(name) {

		}

		public override void Accept(ITeacher teacher) {
			teacher.Visit(this);
		}

	}

}