using System;
using System.Linq;
using System.Reflection;

namespace SingletonPattern.Generic2 {

    public abstract class SingletonGenericBase2<T> where T : class {

        private static readonly Lazy<T> _instance = new Lazy<T>(() => {
            var ctors = typeof(T).GetConstructors(
                BindingFlags.Instance
                | BindingFlags.NonPublic
                | BindingFlags.Public);

            if (ctors.Count() != 1)
                throw new InvalidOperationException(
                    String.Format("Type {0} must have exactly one constructor.",
                                  typeof(T)));

            var ctor = ctors.SingleOrDefault(
                c => !c.GetParameters().Any() && c.IsPrivate);

            if (ctor == null)
                throw new InvalidOperationException(
                    String.Format("The constructor for {0} must be private and take no parameters.",
                                  typeof(T)));

            Console.WriteLine("SingletonGeneric2.GetInstance()!");
            return (T)ctor.Invoke(null);
        });

        public static T GetInstance() {
            return _instance.Value;
        }

    }

    public sealed class SingletonGeneric2 : SingletonGenericBase2<SingletonGeneric2> {

        private SingletonGeneric2() { }

    }

}