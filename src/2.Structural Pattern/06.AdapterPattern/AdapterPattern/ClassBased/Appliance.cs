using System;

namespace AdapterPattern.ClassBased {

	public class Appliance {

		public Voltage GetVoltage() {
			return new Voltage { Value = 220 };
		}

	}

}