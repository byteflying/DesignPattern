using System;

namespace AbstractFactory {

	public class HuaWeiPhone : MobilePhone {

		public override void Print() {
			Console.WriteLine("HuaWei Phone is created by Chinese Factory!");
		}

	}

}