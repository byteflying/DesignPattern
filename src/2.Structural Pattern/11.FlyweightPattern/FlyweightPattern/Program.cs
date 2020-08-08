using System;
using System.Collections.Generic;

namespace FlyweightPattern {

    public class Program {

        private static ConnectionFactory _factory = null;

        private static List<string> _connections = null;

        private static IConnection _connection = null;

        private static void Print(int index) {
            if (index > _connections.Count - 1) {
                Console.WriteLine("Index Out Of Range Exception!");
                return;
            }
            _connection = _factory.CreateConnection(_connections[index]);
            _connection.Print();
        }

        public static void Main(string[] args) {
            _connections = new List<string> {
                "Server=Aron1;Database=pubs;\n" + "Uid=uid;Pwd=password;",
                "Provider=sqloledb;Data Source=Aron1;\n" + "User Id=uid;Password=password;",
                "Data Source=192.168.0.1,1433;\n" + "UserID=uid;Password=password;"
            };

            _factory = new ConnectionFactory();

            Print(0);
            Print(1);
            Print(2);
            Print(1);
            Print(3);

            Console.ReadKey();
        }

    }

}