using System;

namespace AbstractFactory {

	public class DellComputer : Computer {

		public override void Print() {
			Console.WriteLine("Dell Computer is created by American Factory!");
		}

	}

}