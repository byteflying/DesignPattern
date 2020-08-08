using System;

namespace FacadePattern {

	public class Decrypt {

		public string Decipher(string ciphertext) {
			Console.WriteLine("Deciphering ciphertext!");
			Console.WriteLine(Const.LINE_BREAK);
			Console.WriteLine(ciphertext);
			Console.WriteLine(Const.LINE_BREAK);
			return ciphertext;
		}

	}

}