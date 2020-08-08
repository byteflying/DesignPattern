using System;

namespace MediatorPattern {

    public class VipUser : User {

        public VipUser(string name) : base(name) {

        }

        public override void OnRecieve(User sender, string message, bool group = false) {
            var groupFlag = group ? "group" : "private";
            Console.WriteLine(
                $"{this.IdentitySign()} recieved a {groupFlag} message from " +
                $"{sender.IdentitySign()},{Environment.NewLine}(s)he says:{message}");
        }

    }

}