using System;
using System.Runtime.CompilerServices;

namespace SingletonPattern.Generic {

    public abstract class SingletonGenericBase<T> where T : class, new() {

        private static T _instance = null;

        private static readonly object _lock = new object();

        public static T GetInstance() {
            if (_instance == null) {
                lock (_lock) {
                    if (_instance == null) {
                        _instance = new T();
                        Console.WriteLine("SingletonGeneric.GetInstance()!");
                    }
                }
            }
            return _instance;
        }

    }

    public sealed class SingletonGeneric : SingletonGenericBase<Singleton> {

        public SingletonGeneric() { }

    }

}