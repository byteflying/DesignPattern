using System;

namespace FacadePattern {

    public class Program {

        private static Facade _facade = new Facade();

        public static void Main(string[] args) {
            _facade.Handle(new Uri(Const.HAIKWAN_URI));
            Console.ReadKey();
        }

    }

}