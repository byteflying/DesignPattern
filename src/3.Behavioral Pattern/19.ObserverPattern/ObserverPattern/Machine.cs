using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern {

    public class Machine : Publisher {

        public Machine(string name) {
            Name = name;
        }

        protected override void OnPublish(Book book, DateTime publishTime) {
            Console.WriteLine(
                $"{Name} published {book.BookName()} at {publishTime.ToString("yyyy-MM-dd")}." +
                $"->Machine.OnPublish");
            Console.WriteLine(LINE_BREAK);
        }

    }

}