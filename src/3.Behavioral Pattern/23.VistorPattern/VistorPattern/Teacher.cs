using System;

namespace VistorPattern {

	public class Teacher : ITeacher {

		private string _name = null;

		public Teacher(string name) {
			_name = name;
		}

		public void Visit(Student student) {
			Console.WriteLine($"Mr.{_name} is going to visit {student.Name}'s home. ");
		}

	}

}