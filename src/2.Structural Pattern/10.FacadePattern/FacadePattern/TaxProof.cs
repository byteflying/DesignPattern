using System;
namespace FacadePattern {

	public class TaxProof {

		public string TaxNo { get; private set; }

		public decimal Money { get; private set; }

		public DateTime PaymentData { get; private set; }

		public void Deserialize(string plaintext) {
			Console.WriteLine("Creating TaxProof Instance from plaintext!");
			TaxNo = "287361039374492-A01";
			Money = 1986.1020m;
			PaymentData = new DateTime(2018, 07, 20);
		}

	}

}