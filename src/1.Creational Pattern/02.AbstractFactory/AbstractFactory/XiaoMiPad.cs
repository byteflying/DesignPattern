using System;

namespace AbstractFactory {

	public class XiaoMiPad : Tablet {

		public override void Print() {
			Console.WriteLine("XiaoMiPad is created by Chinese Factory!");
		}

	}

}