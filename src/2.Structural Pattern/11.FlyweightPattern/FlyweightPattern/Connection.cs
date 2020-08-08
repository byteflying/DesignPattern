using System;
using System.Threading.Tasks;
using System.Threading;

namespace FlyweightPattern {

    public class Connection : IConnection {

        private string _connectionString = null;

        public Connection(string connectionString) {
            _connectionString = connectionString;
            Thread.Sleep(1000);
            Console.WriteLine("It took 1 second(s) to create a connection!");
        }

        public void Print() {
            Console.WriteLine($"Database connection is {_connectionString}");
            Console.WriteLine("-------------------------------------------------------");
        }

    }

}