using System;

namespace CompositePattern {

    public class File : FileSystem {

        public File(string name) : base(name) {

        }

        public override FileSystem Attach(FileSystem component) {
            throw new FileInvalidException(
                "You can not attach a Component in a file!");
        }

        public override FileSystem Detach(FileSystem component) {
            throw new FileInvalidException(
                "You can not detach a Component from a file!");
        }

        public override void Print(int depth = 0) {
            Console.WriteLine(new string(SPLIT_CHAR_FILE, depth) + _name);
        }

    }

}