using System;

namespace VistorPattern {

	public class Harling : Student {

		public Harling(string name) : base(name) {

		}

		public override void Accept(ITeacher teacher) {
			teacher.Visit(this);
		}

	}

}