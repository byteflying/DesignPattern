using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern {

    public class CancelReceiver : Receiver {

        public void CancelInvoice() {
            var args = CommandArgs as CancelArgs;
            if (args == null) throw new InvalidOperationException();
            Console.WriteLine("Cancel Invoice!");
            Console.WriteLine(
                $"InvoiceCode is {args.InvoiceCode},{Environment.NewLine}" +
                $"InvoiceNumber is {args.InvoiceNumber},{Environment.NewLine}" +
                $"InvoiceType is {args.InvoiceType},{Environment.NewLine}" +
                $"CancelReason is {args.CancelReason},{Environment.NewLine}" +
                $"CancelMan is {args.CancelMan},{Environment.NewLine}" +
                $"CancelDate is {args.CancelDate.ToString("yyyy-MM-dd HH:mm:ss")}!");
            Console.WriteLine(LINE_BREAK);
        }

    }

}