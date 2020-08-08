using System;

namespace FacadePattern {

	public class FileStore {

		public void Store(TaxProof taxProof) {
			Console.WriteLine("Saving taxProof instance to file!");
			Console.WriteLine($"TaxProof.TaxNo = {taxProof.TaxNo},");
			Console.WriteLine($"TaxProof.Money = {taxProof.Money},");
			Console.WriteLine($"TaxProof.PaymentData = {taxProof.PaymentData}!");
			Console.WriteLine(Const.LINE_BREAK);
		}

	}

}