using System;

namespace SingletonPattern.Safe2 {

    public sealed class SingletonSafe2 {

        private static SingletonSafe2 _instance = null;

        private static readonly object _lock = new object();

        public static SingletonSafe2 GetInstance() {
            if (_instance == null) {
                lock (_lock) {
                    if (_instance == null) {
                        _instance = new SingletonSafe2();
                        Console.WriteLine("SingletonSafe2.GetInstance()!");
                    }
                }
            }
            return _instance;
        }

    }

}