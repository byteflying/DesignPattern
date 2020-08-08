using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern {

    public interface IReader {

        void Receive(Publisher publisher, Book book);

    }

}