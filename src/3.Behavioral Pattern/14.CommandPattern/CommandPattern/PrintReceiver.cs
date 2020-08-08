using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern {

    public class PrintReceiver : Receiver {

        public void PrintInvoice() {
            var args = CommandArgs as PrintArgs;
            if (args == null) throw new InvalidOperationException();
            Console.WriteLine("Print Invoice!");
            Console.WriteLine(
                $"InvoiceCode is {args.InvoiceCode},{Environment.NewLine}" +
                $"InvoiceNumber is {args.InvoiceNumber},{Environment.NewLine}" +
                $"InvoiceType is {args.InvoiceType}!");
            Console.WriteLine(LINE_BREAK);
        }

    }

}