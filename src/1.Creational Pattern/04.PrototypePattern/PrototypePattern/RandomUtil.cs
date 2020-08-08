using System;

namespace PrototypePattern {

	public class RandomUtil {

		public static int RandomNum() {
			return new Random().Next(1000000, 10000000);
		}

	}

}