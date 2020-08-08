using System;

namespace CommandPattern {

	public class CancelArgs : CommandArgs {

		public string InvoiceCode { get; set; }
		public int InvoiceNumber { get; set; }
		public string CancelReason { get; set; }
		public string CancelMan { get; set; }
		public DateTime CancelDate { get; set; }

	}

}