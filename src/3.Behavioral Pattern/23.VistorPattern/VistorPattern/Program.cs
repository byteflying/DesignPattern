using System;

namespace VistorPattern {

	public class Program {

		public static void Main(string[] args) {
			Roster roster = new Roster();
			foreach(var student in roster.Students) {
				student.Accept(new Teacher("Tony"));
			}

			Console.Read();
		}

	}

}