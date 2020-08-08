using System;
using System.Collections.Generic;

namespace BuilderPattern {

    public class Program {

        private static Director _director = null;

        private static List<Builder> _builders = null;

        private static Vehicle _vehicle = null;

        public static void Main(string[] args) {
            _director = new Director();
            _vehicle = new Vehicle();

            _builders = new List<Builder>() {
                new Tesla(),
                new Volkswagen(),
                new Yuedakia()
            };

            foreach (var builder in _builders) {
                _director.Construct(builder);
                _vehicle = builder.GetResult();
                _vehicle.Print();
            }

            Console.ReadKey();
        }

    }

}