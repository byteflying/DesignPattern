using System;

namespace StatePattern {

    public class Program {

        private static Water _water = new Water();

        public static void Main(string[] args) {
            try {
                _water.Increase(68)
                      .Drink()
                      .Increase(82)
                      .Drink()
                      .Reduce(90)
                      .Drink()
                      .Reduce(0)
                      .Reduce(80)
                      .Drink()
                      .Reduce(300)
                      .Drink();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(Const.LINE_BREAK);
            }

            Console.ReadKey();
        }

    }

}