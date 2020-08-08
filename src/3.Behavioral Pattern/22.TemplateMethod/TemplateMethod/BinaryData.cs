using System;

namespace TemplateMethod {

    public class BinaryData : DataSource {

        protected override void FetchSource() {
            Console.WriteLine($"Fetch data from {this.ToString()}!");
        }

        protected override void Convert2Json() {
            Console.WriteLine($"Convert {this.ToString()} to Json!");
        }

        protected override void ShowData() {
            Console.WriteLine($"Show data in chart control!");
        }

    }

}