using System;

namespace SingletonPattern.Lazy {

    public sealed class SingletonLazy {

        private static readonly Lazy<SingletonLazy> _instance =
            new Lazy<SingletonLazy>(() => {
                Console.WriteLine("SingletonLazy.GetInstance()!");
                return new SingletonLazy();
            });

        public static SingletonLazy GetInstance() {
            return _instance.Value;
        }

    }

}