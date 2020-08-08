using System;

namespace AbstractFactory {

	public abstract class DeviceFactory {

		public abstract MobilePhone CreateMobilePhone();

		public abstract Computer CreateComputer();

		public abstract Tablet CreatePad();

	}

}