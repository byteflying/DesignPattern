using System;

namespace TemplateMethod {

    public class Program {

        private static DataSource _dataSource = null;

        public static void Main(string[] args) {
            _dataSource = new TextData();
            _dataSource.ShowChart();

            _dataSource = new BinaryData();
            _dataSource.ShowChart();

            _dataSource = new JsonData();
            _dataSource.ShowChart();

            _dataSource = new CloudData();
            _dataSource.ShowChart();

            Console.ReadKey();
        }

    }

}