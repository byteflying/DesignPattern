using System;
using System.Collections;

namespace IteratorPattern {

    public class PeopleEnum : IEnumerator {

        private Person[] _people = null;

        private int _cursor = -1;

        public PeopleEnum(Person[] list) {
            _people = list;
        }

        public bool MoveNext() {
            _cursor++;
            return (_cursor < _people.Length);
        }

        public void Reset() {
            _cursor = -1;
        }

        public object Current {
            get {
                try {
                    return _people[_cursor];
                }
                catch (IndexOutOfRangeException) {
                    throw new InvalidOperationException();
                }
            }
        }

    }

}