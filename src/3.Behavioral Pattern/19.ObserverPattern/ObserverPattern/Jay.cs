using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern {

    public class Jay : IReader {

        public void Receive(Publisher publisher, Book book) {
            Console.WriteLine(
                $"{this.ReaderName()} received {book.BookName()} from {publisher.Name}.");
        }

    }

}