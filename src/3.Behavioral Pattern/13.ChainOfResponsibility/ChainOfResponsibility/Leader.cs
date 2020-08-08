using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility {

    public abstract class Leader {

        protected string Name { get; set; }

        protected Leader(string name) {
            this.Name = name;
        }

        public static LeaderChain Chain { protected get; set; }

        public abstract void ProcessRequest(LeaveRequest request);

        protected void Delivery(LeaveRequest request) {
            Chain.DoChain(request);
        }

    }

}