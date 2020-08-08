using System;

namespace DecoratorPattern {

    public class Program {

        private const string LINE_SPLIT = "-------------------------";

        private static Car _car = null;

        private static CoolCar _coolCar = null;

        public static void Main(string[] args) {
            _car = new Maserati();

            _coolCar = new Visor(_car);
            _coolCar.StartUp();
            Console.WriteLine(LINE_SPLIT);

            _car = new Fabbrica();

            _coolCar = new Paster(_car);
            _coolCar.StartUp();
            Console.WriteLine(LINE_SPLIT);

            Console.ReadKey();
        }

    }

}