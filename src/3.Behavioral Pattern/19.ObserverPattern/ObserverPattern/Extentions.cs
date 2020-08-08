using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern {

    public static class Extentions {

        public static string ReaderName(this IReader reader) {
            return reader.ToString().Replace(nameof(ObserverPattern) + ".", "");
        }

        public static string BookName(this Book book) {
            return "[" + book.Name + "]";
        }

    }

}