using System;
using System.Collections.Generic;

namespace ChainOfResponsibility {

    public class Program {

        public static void Main(string[] args) {
            var leaders = new List<Leader>{
                new Manager("Tom"),
                new Inspector("Juice"),
                new President("Iori"),
                new Directorate("TMarinom")
            };

            var chain = new LeaderChain();
            foreach (var leader in leaders) {
                chain.Attach(leader);
            }

            Leader.Chain = chain;

            var requests = new List<LeaveRequest> {
                new LeaveRequest(1, "Zhao"),
                new LeaveRequest(3, "Qian"),
                new LeaveRequest(5, "Sun"),
                new LeaveRequest(7, "Li"),
                new LeaveRequest(12, "Zhou")
            };

            foreach (var request in requests) {
                leaders[0].ProcessRequest(request);
            }

            Console.ReadKey();
        }

    }

}