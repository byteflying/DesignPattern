using System;
using System.Collections;
using System.Collections.Generic;

namespace FlyweightPattern {

    public class ConnectionFactory {

        private Dictionary<string, IConnection> _connections = null;

        private string _connectionString = null;

        public ConnectionFactory() {
            _connections = new Dictionary<string, IConnection>();
        }

        public IConnection CreateConnection(string connectionString) {
            if (!_connections.ContainsKey(connectionString)) {
                Console.WriteLine("Creating a new connection!");
                IConnection connection = new Connection(connectionString);
                _connections.Add(connectionString, connection);
                return connection;
            }
            else {
                Console.WriteLine("Return an exist connection!");
                var connection = _connections[connectionString] as IConnection;
                return connection;
            }

        }

    }

}