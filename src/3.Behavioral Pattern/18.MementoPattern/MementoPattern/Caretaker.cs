using System;

namespace MementoPattern {

    public class Caretaker {

        public Memento Memento { get; set; }

        public Caretaker(Memento memento) {
            Memento = memento;
        }

    }

}