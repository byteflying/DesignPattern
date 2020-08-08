using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern {

    public class CreateReceiver : Receiver {

        public void CreateInvoice() {
            var args = CommandArgs as CreateArgs;
            if (args == null) throw new InvalidOperationException();
            Console.WriteLine("Create Invoice!");
            Console.WriteLine(
                $"InvoiceType is {args.InvoiceType},{Environment.NewLine}" +
                $"BillingDate is {args.BillingDate.ToString("yyyy-MM-dd HH:mm:ss")}!");
            Console.WriteLine(LINE_BREAK);
        }

    }

}