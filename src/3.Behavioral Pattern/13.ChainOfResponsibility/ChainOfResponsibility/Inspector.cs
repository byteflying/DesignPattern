using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility {

    public class Inspector : Leader {

        public Inspector(string name) : base(name) { }

        public override void ProcessRequest(LeaveRequest request) {
            if (request.Days <= 4) {
                Console.WriteLine($"{this.Name} approved {request.Name}'s " +
                                  $"leave request for {request.Days} days!");
                return;
            }
            Delivery(request);
        }

    }

}