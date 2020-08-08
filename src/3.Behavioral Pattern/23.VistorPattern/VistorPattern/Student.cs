using System;

namespace VistorPattern {

	public abstract class Student {

		public string Name { get; protected set; }

		public Student(string name) {
			Name = name;
		}

		public abstract void Accept(ITeacher teacher);

	}

}