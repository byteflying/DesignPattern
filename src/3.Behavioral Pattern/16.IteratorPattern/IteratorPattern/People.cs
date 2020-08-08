using System;
using System.Collections;

namespace IteratorPattern {

    public class People : IEnumerable {

        private Person[] _people = null;

        public People(Person[] pArray) {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++) {
                _people[i] = pArray[i];
            }
        }

        public IEnumerator GetEnumerator() {
            return new PeopleEnum(_people);
        }

    }

}