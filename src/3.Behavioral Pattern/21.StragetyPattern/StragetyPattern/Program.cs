using System;

namespace StragetyPattern {

    public class Program {

        private static Context _context = new Context();

        public static void Main(string[] args) {
            _context.Calculate(2500.00m)
                    .Calculate(4900.00m)
                    .Calculate(5500.00m)
                    .Calculate(7000.00m)
                    .Calculate(10000.00m)
                    .Calculate(16000.00m)
                    .Calculate(43000.00m)
                    .Calculate(70000.00m)
                    .Calculate(100000.00m)
                    .Calculate(4500.00m)
                    .Calculate(1986.00m);

            Console.ReadKey();
        }

    }

}