using System;
using System.Collections.Generic;

namespace CompositePattern {

    public class Folder : FileSystem {

        private List<FileSystem> _childrens = null;

        public Folder(string name) : base(name) {
            _childrens = new List<FileSystem>();
        }

        public override FileSystem Attach(FileSystem component) {
            _childrens.Add(component);
            return this;
        }

        public override FileSystem Detach(FileSystem component) {
            _childrens.Remove(component);
            return this;
        }

        public override void Print(int depth = 0) {
            Console.WriteLine(new string(SPLIT_CHAR_DIR, depth) + _name);
            foreach (var component in _childrens) {
                component.Print(depth + 1);
            }
        }

    }

}