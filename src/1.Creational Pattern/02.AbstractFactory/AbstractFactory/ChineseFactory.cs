using System;

namespace AbstractFactory {

	public class ChineseFactory : DeviceFactory {

		public override MobilePhone CreateMobilePhone() {
			return new HuaWeiPhone();
		}

		public override Computer CreateComputer() {
			return new LenovoComputer();
		}

		public override Tablet CreatePad() {
			return new XiaoMiPad();
		}

	}

}