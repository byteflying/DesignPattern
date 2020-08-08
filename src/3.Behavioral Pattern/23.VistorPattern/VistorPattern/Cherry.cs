using System;

namespace VistorPattern {

	public class Cherry : Student {

		public Cherry(string name) : base(name) {

		}

		public override void Accept(ITeacher teacher) {
			teacher.Visit(this);
		}

	}

}