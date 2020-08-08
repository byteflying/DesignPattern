using System;

namespace TemplateMethod {

    public abstract class DataSource {

        protected abstract void FetchSource();

        protected virtual bool IsNotJson() {
            return true;
        }

        protected abstract void Convert2Json();

        protected abstract void ShowData();

        public void ShowChart() {
            FetchSource();
            if (IsNotJson()) {
                Convert2Json();
            }
            ShowData();
            Console.WriteLine("----------------------------------");
        }

    }

}