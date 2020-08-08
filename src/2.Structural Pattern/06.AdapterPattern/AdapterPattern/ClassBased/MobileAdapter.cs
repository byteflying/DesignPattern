using System;

namespace AdapterPattern.ClassBased {

	public class MobileAdapter : Appliance, ITarget {

		public Voltage GetMobileVoltage() {
			var voltage = GetVoltage();
			Console.WriteLine($"Appliance voltage is {voltage.Value}V!");
			voltage.Value = 3;
			Console.WriteLine($"After adapted,it becomes {voltage.Value}V!");
			return voltage;
		}

	}

}