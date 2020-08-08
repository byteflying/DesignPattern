using System;

namespace CommandPattern {

    public class Program {

        private static Receiver _receiver = null;

        public static void Main(string[] args) {
            _receiver = new CreateReceiver();
            Command command = new CreateCommand(
                _receiver, new CreateArgs {
                    InvoiceType = "c",
                    BillingDate = DateTime.UtcNow
                });

            var invoker = new Invoker(command);
            invoker.Execute();

            _receiver = new CancelReceiver();
            command = new CancelCommand(
                _receiver, new CancelArgs {
                    InvoiceCode = "310987289304",
                    InvoiceNumber = 34156934,
                    InvoiceType = "s",
                    CancelReason = "Invoice missing!",
                    CancelMan = "Iori",
                    CancelDate = DateTime.UtcNow
                });

            invoker = new Invoker(command);
            invoker.Execute();

            _receiver = new PrintReceiver();
            command = new PrintCommand(
                _receiver, new PrintArgs {
                    InvoiceCode = "310987289304",
                    InvoiceNumber = 34156934,
                    InvoiceType = "s"
                });

            invoker = new Invoker(command);
            invoker.Execute();

            Console.ReadKey();
        }

    }

}