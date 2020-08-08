using System;

namespace SingletonPattern.Safe {

    public sealed class SingletonSafe {

        private static SingletonSafe _instance = null;

        private static readonly object _lock = new object();

        public static SingletonSafe GetInstance() {
            lock (_lock) {
                if (_instance == null) {
                    _instance = new SingletonSafe();
                    Console.WriteLine("SingletonSafe.GetInstance()!");
                }
            }
            return _instance;
        }

    }

}