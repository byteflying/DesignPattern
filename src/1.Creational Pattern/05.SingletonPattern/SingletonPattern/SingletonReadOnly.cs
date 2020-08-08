using System;

namespace SingletonPattern.ReadOnly {

    public sealed class SingletonReadOnly {

        private static readonly SingletonReadOnly _instance =
            new SingletonReadOnly();

        public SingletonReadOnly() {
            Console.WriteLine("SingletonReadOnly.GetInstance()!");
        }

        public static SingletonReadOnly GetInstance() {
            return _instance;
        }

    }

}