using System;

namespace ProxyPattern {

	public class Leader : Employee {

		private Staff _staff = null;

		public Leader() {
			_staff = new Staff();
		}

		public override void Purchase(string goods) {
			_staff.Purchase(goods);
		}

	}

}