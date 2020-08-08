using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern {

    public abstract class Publisher {

        private List<IReader> _readers = new List<IReader>();

        public string Name { get; set; }
        protected const string LINE_BREAK =
            "----------------------------------------" +
            "----------------------------------------";
        //文章排版需要，故折成2行

        public void AttachReader(IReader reader) {
            if (reader == null) throw new ArgumentNullException();
            _readers.Add(reader);
        }

        public bool DetachReader(IReader reader) {
            if (reader == null) throw new ArgumentNullException();
            return _readers.Remove(reader);
        }

        protected virtual void OnPublish(Book book, DateTime publishTime) {
            Console.WriteLine(
                $"{Name} published {book.BookName()} at {publishTime.ToString("yyyy-MM-dd")}.");
            Console.WriteLine(LINE_BREAK);
        }

        public void Publish(Book book, DateTime publishTime) {
            OnPublish(book, publishTime);
            foreach (var reader in _readers) {
                if (reader != null) {
                    reader.Receive(this, book);
                }
            }
            Console.WriteLine(LINE_BREAK);
        }

    }

}