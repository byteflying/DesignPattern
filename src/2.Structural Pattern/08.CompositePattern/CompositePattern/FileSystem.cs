using System;

namespace CompositePattern {

    public abstract class FileSystem {

        protected string _name = null;

        protected const char SPLIT_CHAR_FILE = ' ';

        protected const char SPLIT_CHAR_DIR = '▼';

        public FileSystem(string name) {
            this._name = name;
        }

        public abstract FileSystem Attach(FileSystem component);

        public abstract FileSystem Detach(FileSystem component);

        public abstract void Print(int depth = 0);

    }

}