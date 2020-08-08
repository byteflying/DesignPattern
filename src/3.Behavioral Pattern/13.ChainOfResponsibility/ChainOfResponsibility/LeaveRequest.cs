using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility {

    public class LeaveRequest {

        public int Days { get; set; }

        public string Name { get; set; }

        public LeaveRequest(int days, string name) {
            Days = days;
            Name = name;
        }

    }

}