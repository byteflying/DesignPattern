using System;
using System.Runtime.InteropServices;
using System.Data;

namespace PrototypePattern {

	[Serializable]
	public abstract class Cell : CloneBase<Cell> {

		public int Id { get; set; }

		public string Wall { get; set; }//细胞壁

		public string Membrane { get; set; }//细胞膜

		public string Cytoplasm { get; set; }//细胞质

		public string Nucleus { get; set; }//细胞核

		public Content Content { get; set; } = new Content();//细胞器

		public Cell(int id,
					string wall,
					string membrane,
					string cytoplasm,
					string nucleus) {
			this.Id = id;
			this.Wall = wall;
			this.Membrane = membrane;
			this.Cytoplasm = cytoplasm;
			this.Nucleus = nucleus;
			this.Content = new Content();
		}

		public abstract Cell Division();

	}

}