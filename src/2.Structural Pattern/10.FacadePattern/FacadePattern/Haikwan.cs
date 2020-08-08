using System;

namespace FacadePattern {

	public class Haikwan {

		public string Apply(Uri uri) {
			Console.WriteLine($"Apply some data from {uri.ToString()}!");
			return Const.TEMPLET_HAIKWAN;
		}

	}

}