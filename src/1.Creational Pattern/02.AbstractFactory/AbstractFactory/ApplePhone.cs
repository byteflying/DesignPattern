using System;

namespace AbstractFactory {

	public class ApplePhone : MobilePhone {

		public override void Print() {
			Console.WriteLine("Apple Phone is created by American Factory!");
		}

	}

}