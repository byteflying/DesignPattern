using System;

namespace ProxyPattern {

	public class Staff : Employee {

		public override void Purchase(string goods) {
			OnPurchasing();
			Console.WriteLine($"Purchase some {goods}s!");
			OnPurchased();
		}

		protected override void OnPurchasing() {
			Console.WriteLine("Staff.OnPurchasing()");
		}

		protected override void OnPurchased() {
			Console.WriteLine("Staff.OnPurchasing()");
		}

	}

}