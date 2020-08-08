using System;
using SingletonPattern.Generic;
using SingletonPattern.Generic2;
using SingletonPattern.Lazy;
using SingletonPattern.ReadOnly;
using SingletonPattern.Safe;
using SingletonPattern.Safe2;

namespace SingletonPattern {

    public class Program {

        public static void Main(string[] args) {
            var singleton = Singleton.GetInstance();
            singleton = Singleton.GetInstance();

            var singletonSafe = SingletonSafe.GetInstance();
            singletonSafe = SingletonSafe.GetInstance();

            var singletonSafe2 = SingletonSafe2.GetInstance();
            singletonSafe2 = SingletonSafe2.GetInstance();

            var singletonReadOnly = SingletonReadOnly.GetInstance();
            singletonReadOnly = SingletonReadOnly.GetInstance();

            var singletonLazy = SingletonLazy.GetInstance();
            singletonLazy = SingletonLazy.GetInstance();

            var singletonGeneric = SingletonGeneric.GetInstance();
            singletonGeneric = SingletonGeneric.GetInstance();

            var singletonGeneric2 = SingletonGeneric2.GetInstance();
            singletonGeneric2 = SingletonGeneric2.GetInstance();

            Console.ReadKey();
        }

    }

}