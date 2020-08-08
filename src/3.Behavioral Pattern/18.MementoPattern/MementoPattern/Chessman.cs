using System;
using System.Drawing;

namespace MementoPattern {

	public partial class Chessman {

		private Point _position;

		private Caretaker _caretaker = null;

		public Point Position {
			get => _position;
			set {
				_position = value;
				_caretaker.Memento.Position = value; Console.WriteLine(
				 String.Format(Const.POSITION_INFO, _position.X, _position.Y));
			}
		}

		public Chessman() : this(new Point(0, 0)) {

		}

		public Chessman(Point point) {
			_caretaker = new Caretaker(new Memento());
			Position = point;
		}

	}

	public partial class Chessman {

		public Chessman Undo(int step) {
			try {
				Console.WriteLine(Const.ARROW_LEFT);
				Console.WriteLine($"Undo({step})!");
				this._position = _caretaker.Memento.Undo(step);
				Console.WriteLine(
					String.Format(Const.POSITION_INFO, _position.X, _position.Y));
				Console.WriteLine(Const.ARROW_RIGHT);
				return this;
			} catch(Exception ex) {
				Console.WriteLine(ex.Message);
				Console.WriteLine(Const.ARROW_RIGHT);
				return this;
			}
		}

		public Chessman Redo() {
			try {
				Console.WriteLine(Const.ARROW_LEFT);
				Console.WriteLine("Redo()!");
				this._position = _caretaker.Memento.Redo();
				Console.WriteLine(
					String.Format(Const.POSITION_INFO, _position.X, _position.Y));
				Console.WriteLine(Const.ARROW_RIGHT);
				return this;

			} catch(Exception ex) {
				Console.WriteLine(ex.Message);
				Console.WriteLine(Const.ARROW_RIGHT);
				return this;
			}
		}

	}

}