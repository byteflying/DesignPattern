using System;

namespace ProxyPattern {

	public abstract class Employee {

		public abstract void Purchase(string goods);

		protected virtual void OnPurchasing() {
			Console.WriteLine("Employee.OnPurchasing()");
		}

		protected virtual void OnPurchased() {
			Console.WriteLine("Employee.OnPurchased()");
		}

	}

}