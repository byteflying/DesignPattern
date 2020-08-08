using System;
using System.Collections.Generic;

namespace MediatorPattern {

    public class Program {

        private static ChatRoom _chatRoom;

        public static void Main(string[] args) {
            _chatRoom = new SinaChat();

            var juice = new GeneralUser("Juice");
            var cola = new GeneralUser("Cola");
            var iori = new VipUser("Iori");
            var marin = new VipUser("Marin");

            _chatRoom.Attach(juice);
            _chatRoom.Attach(cola);
            _chatRoom.Attach(iori);
            _chatRoom.Attach(marin);

            _chatRoom.Talk2All(juice, "Hello Every one!");
            _chatRoom.Talk2User(cola, iori, "Hello Iori!");
            _chatRoom.Talk2User(iori, marin, "Hello Marin!");

            Console.ReadKey();
        }

    }

}