using System;

namespace SingletonPattern {

	public sealed class Singleton {

		private static Singleton _instance = null;

		public static Singleton GetInstance() {
			if(_instance == null) {
				_instance = new Singleton();
				Console.WriteLine("Singleton.GetInstance()!");
			}
			return _instance;
		}

	}

}