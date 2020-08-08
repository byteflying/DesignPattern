using System;

namespace PrototypePattern {

	[Serializable]
	public class Content {

		public string Mitochondria { get; set; }//线粒体

		public int Chloroplasts { get; set; }//叶绿体

		public int EndoplasmicReticulum { get; set; }//内质网

		public int GolgiBody { get; set; }//高尔基复合体

		public int Ribosomes { get; set; }//核糖体

		public int Centrosome { get; set; }//中心体

		public int Vacuole { get; set; }//液泡

		public int Lysosomes { get; set; }//溶酶体

		public int Microtubule { get; set; }//微管

	}

}