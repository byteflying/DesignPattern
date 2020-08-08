using System;

namespace AbstractFactory {

	public class AmericanFactory : DeviceFactory {

		public override MobilePhone CreateMobilePhone() {
			return new ApplePhone();
		}

		public override Computer CreateComputer() {
			return new DellComputer();
		}

		public override Tablet CreatePad() {
			return new Nexus10();
		}

	}

}