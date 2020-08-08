using System;
using System.Drawing;

namespace MementoPattern {

    public class Program {

        private static Chessman _chessman = null;

        public static void Main(string[] args) {
            _chessman = new Chessman(new Point(1, 10));
            _chessman.Position = new Point(2, 20);
            _chessman.Position = new Point(3, 30);
            _chessman.Position = new Point(4, 40);
            _chessman.Position = new Point(5, 50);
            _chessman.Position = new Point(9, 40);

            _chessman.Undo(1)
                     .Undo(2)
                     .Undo(1)
                     .Redo()
                     .Redo()
                     .Redo()
                     .Redo()
                     .Redo()
                     .Undo(6)
                     .Undo(5)
                     .Undo(4);

            Console.ReadKey();
        }

    }

}