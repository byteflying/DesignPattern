using System;

namespace AbstractFactory {

	public class Program {

		public static void Main(string[] args) {
			CreateDevice<ChineseFactory>.Create();
			CreateDevice<AmericanFactory>.Create();

			Console.ReadKey();
		}

	}

}