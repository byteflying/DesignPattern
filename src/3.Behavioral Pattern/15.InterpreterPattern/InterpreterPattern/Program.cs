using System;

namespace InterpreterPattern {

	public class Program {

		private static Interpreter _interpreter = new Interpreter();

		public static void Main(string[] args) {
			string instruction = "340.00 10.00 taxing 1.00;" +
				"27.00 120.00 takeoff 1.00;" +
				"90.00 350.00 fly 30.00;" +
				"180.00 400.00 cruise 230.00;" +
				"50.00 320.00 fly 20.00;" +
				"320.00 110.00 landing 3.00;" +
				"120.00 10.00 taxing 3.00;";

			Console.WriteLine(_interpreter.Interpret(instruction));

			Console.ReadKey();
		}

	}

}