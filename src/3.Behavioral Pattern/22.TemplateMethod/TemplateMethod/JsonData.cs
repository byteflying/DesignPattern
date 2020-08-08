using System;

namespace TemplateMethod {

    public class JsonData : DataSource {

        protected override void FetchSource() {
            Console.WriteLine($"Fetch data from {this.ToString()}!");
        }

        protected override bool IsNotJson() {
            return false;
        }

        protected override void Convert2Json() {
            Console.WriteLine("This line can not be reached!");
            Console.WriteLine("There's no need to convert data!");
        }

        protected override void ShowData() {
            Console.WriteLine($"Show data in chart control!");
        }

    }

}