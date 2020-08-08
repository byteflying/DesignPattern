using System;

namespace AdapterPattern {

	public class Program {

		private static ClassBased.ITarget _targetClass = null;
		private static ObjectBased.ITarget _targetObject = null;

		public static void Main(string[] args) {
			//ClassPattern
			_targetClass = new ClassBased.MobileAdapter();
			var voltage = _targetClass.GetMobileVoltage();

			Console.WriteLine("-----------------------------");

			//ObjectPattern
			_targetObject = new ObjectBased.Adapter();
			_targetObject.TargetMethod();

			Console.ReadKey();
		}

	}

}