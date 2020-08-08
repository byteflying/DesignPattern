using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace MementoPattern {

    public partial class Memento {

        private Point _position;

        public Point Position {
            get => _position;
            set {
                _position = value;
                _history.Push(new RedoInfo { Position = value });
                _redoList.Clear();
            }
        }

        public Memento() {
            _history = new Stack<RedoInfo>();
            _redoList = new Stack<RedoInfo>();
        }

        private Stack<RedoInfo> _history = null;
        private Stack<RedoInfo> _redoList = null;

        public Point Undo(int step) {
            int totalCount = 0;
            List<string> temp = new List<string>();
            foreach (var item in _history) {
                if (string.IsNullOrWhiteSpace(item.GUID)) {
                    totalCount++;
                }
                else {
                    if (!temp.Contains(item.GUID)) {
                        totalCount++;
                        temp.Add(item.GUID);
                    }
                }
            }
            if (step >= totalCount) {
                throw new InvalidOperationException("Too much steps!");
            }
            var guid = Guid.NewGuid().ToString("B");
            for (int i = 1; i <= step; i++) {
                Undo(guid);
            }
            return _position;
        }

    }

    public partial class Memento {

        private void UndoLoop(string guid) {
            var history = _history.Pop();
            history.GUID = guid;
            _redoList.Push(history);
            _position = _history.Peek().Position;
        }

        private void Undo(string guid) {
            var temp = _history.Peek().GUID;
            if (string.IsNullOrWhiteSpace(temp)) {
                UndoLoop(guid);
            }
            else {
                while (_history.Peek().GUID == temp) {
                    UndoLoop(guid);
                }
            }
        }

        public Point Redo() {
            if (_redoList.Count == 0) {
                throw new InvalidOperationException("You can not redo now!");
            }
            var guid = _redoList.Peek().GUID;
            while (_redoList.Count != 0 && _redoList.Peek().GUID == guid) {
                _history.Push(_redoList.Pop());
                _position = _history.Peek().Position;
            }
            return _position;
        }

    }

}