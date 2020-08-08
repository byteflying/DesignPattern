using System;

namespace AbstractFactory {

	public class LenovoComputer : Computer {

		public override void Print() {
			Console.WriteLine("Lenovo Computer Phone is created by Chinese Factory!");
		}

	}

}