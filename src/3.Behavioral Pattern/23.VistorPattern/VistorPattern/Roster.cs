using System;
using System.Collections;
using System.Collections.Generic;

namespace VistorPattern {

	public class Roster {

		public List<Student> Students { get; private set; }

		public Roster() {
			Students = new List<Student> {
				new Cherry("Cherry"),
				new Kris("Kris"),
				new Harling("Harling")
			};
		}

	}

}