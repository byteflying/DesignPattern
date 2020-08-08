using System;

namespace ObserverPattern {

    public class Program {

        public static void Main(string[] args) {
            Publisher publisher = new Machine("China Machine Press");

            var iori = new Iori();
            var jay = new Jay();

            publisher.AttachReader(iori);
            publisher.AttachReader(jay);

            publisher.Publish(new Book("How the Steel Was Tempered"), DateTime.UtcNow);

            publisher.DetachReader(jay);

            publisher.Publish(new Book("Jane Eyre"), DateTime.UtcNow);

            publisher = new Agriculture("China Agriculture Press");

            publisher.AttachReader(iori);
            publisher.AttachReader(jay);

            publisher.Publish(new Book("Romance of the Three Kingdoms"), DateTime.UtcNow);

            Console.ReadKey();
        }

    }

}