using System;

namespace AdapterPattern.ObjectBased {

	public class Adapter : Target {

		private Adaptee _adaptee = new Adaptee();

		public override void TargetMethod() {
			_adaptee.OriginalMethod();
		}

	}

}