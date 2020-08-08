using System;

namespace StatePattern {

    public class UnReachableException : Exception {

        public UnReachableException()
            : base("Absolute zero cannot be reached!") {

        }

        public UnReachableException(string message, Exception innerException)
            : base(message, innerException) {

        }

    }

}