using System;

namespace AdapterPattern.ObjectBased {

	public class Target : ITarget {

		public virtual void TargetMethod() {
			Console.WriteLine("Target Method is being called!");
		}

	}

}