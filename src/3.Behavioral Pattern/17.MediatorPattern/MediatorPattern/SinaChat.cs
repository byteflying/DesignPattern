using System;
using System.Linq;

namespace MediatorPattern {

    public class SinaChat : ChatRoom {

        public override void Talk2All(User sender, string message) {
            _users.Where(u => u.Name != sender.Name)
                  .ToList()
                  .ForEach((u) => u.OnRecieve(sender, message, true));
            Console.WriteLine(SPLIT_BREAK);
        }

        public override void Talk2User(User sender, User reciever, string message) {
            var user = _users.Where(u => u.Name == reciever.Name)
                             .FirstOrDefault();
            user.OnRecieve(sender, message);
            Console.WriteLine(SPLIT_BREAK);
        }

    }

}