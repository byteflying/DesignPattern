using System;

namespace AbstractFactory {

	public class CreateDevice<T> where T : DeviceFactory {

		private static T _deviceFactory = null;

		public static void Create() {
			_deviceFactory = Activator.CreateInstance<T>();
			_deviceFactory.CreateMobilePhone().Print();
			_deviceFactory.CreateComputer().Print();
			_deviceFactory.CreatePad().Print();
		}

	}

}