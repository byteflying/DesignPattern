using System;
using System.Runtime.InteropServices;

namespace PrototypePattern {

	[Serializable]
	public class AnimalCell : Cell {

		public AnimalCell(int id,
						  string wall,
						  string membrane,
						  string cytoplasm,
						  string nucleus)
			: base(id, wall, membrane, cytoplasm, nucleus) {

		}

		public override Cell Division() {
			var cell = this.MemberwiseClone() as Cell;
			cell.Id = RandomUtil.RandomNum();
			return cell;
		}

	}

}