using System;
using System.Collections;
using System.Collections.Generic;

namespace InterpreterPattern {

	public class Interpreter {

		private IWord _word = null;

		private Instruction _instruction = null;

		public string Interpret(string instruction) {
			string[] instrucs = instruction.Split(';');

			foreach(var word in instrucs) {
				if(word.Trim() == "") break;
				string[] words = word.Split(' ');

				_instruction = new Instruction(new Course(double.Parse(words[0])),
											   new Speed(double.Parse(words[1])),
											   new Movement(words[2]),
											   new Voyage(double.Parse(words[3])));

				if(_word == null) {
					_word = _instruction;
				} else {
					_word = new Semicolon(_word, _instruction);
				}
			}

			return _word.Interpret();
		}

	}

}