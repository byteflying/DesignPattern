using System;
using System.Collections.Generic;

namespace MediatorPattern {

    public abstract class ChatRoom {

        protected List<User> _users = null;

        protected const string SPLIT_BREAK =
            "------------------------------------------------------";

        protected ChatRoom() {
            _users = new List<User>();
        }

        public void Attach(User user) {
            if (user == null) throw new ArgumentNullException();
            _users.Add(user);
        }

        public bool Detach(User user) {
            if (user == null) throw new ArgumentNullException();
            return _users.Remove(user);
        }

        public abstract void Talk2All(User sender, string message);
        public abstract void Talk2User(User sender, User reciever, string message);

    }

}