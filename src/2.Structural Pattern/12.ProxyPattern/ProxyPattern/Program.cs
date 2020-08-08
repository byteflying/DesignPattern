using System;

namespace ProxyPattern {

	public class Program {

		private static Employee _employee = null;

		public static void Main(string[] args) {
			_employee = new Leader();
			_employee.Purchase("desk");

			Console.ReadKey();
		}

	}

}