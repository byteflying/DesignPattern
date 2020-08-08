using System;

namespace CompositePattern {

    public class FileInvalidException : Exception {

        public FileInvalidException(string message) : base(message) {

        }

        public FileInvalidException(string message, Exception innerException)
            : base(message, innerException) {

        }

    }

}