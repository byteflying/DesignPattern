using System;

namespace MediatorPattern {

    public abstract class User {

        public string Name { get; private set; }

        protected User(string name) {
            Name = name;
        }

        public abstract void OnRecieve(User sender, string message, bool group = false);

    }

}