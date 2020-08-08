using System;
using System.Collections.Generic;

namespace ChainOfResponsibility {

    public class LeaderChain {

        private List<Leader> _leaders = new List<Leader>();

        private int _cursor = 0;

        public void Attach(Leader leader) {
            if (leader == null) throw new ArgumentNullException();
            _leaders.Add(leader);
        }

        public bool Detach(Leader leader) {
            if (leader == null) throw new ArgumentNullException();
            return _leaders.Remove(leader);
        }

        public void DoChain(LeaveRequest request) {
            if (_cursor <= _leaders.Count - 2) {
                _leaders[++_cursor].ProcessRequest(request);
            }
            _cursor = 0;
        }

    }

}