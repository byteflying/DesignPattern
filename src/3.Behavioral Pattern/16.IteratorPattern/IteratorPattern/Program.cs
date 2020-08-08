using System;

namespace IteratorPattern {

    public class Program {

        public static void Main(string[] args) {
            var peopleArray = new Person[]
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon")
            };

            var peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                Console.WriteLine(p.FirstName + " " + p.LastName);

            Console.WriteLine("---------------------");

            var iterator = peopleList.GetEnumerator();
            while (iterator.MoveNext()) {
                var person = iterator.Current as Person;
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }

            Console.WriteLine("---------------------");

            foreach (var phone in BestEnum.GetIPhones()) {
                Console.WriteLine("[" + phone.PhoneName + "] was released in " +
                                  phone.PublishedDate.ToString("yyyy-MM-dd") + "!");
            }

            Console.WriteLine("---------------------------------------------");

            Console.ReadKey();
        }

    }

}