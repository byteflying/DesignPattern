using System;
using System.Data;

namespace PrototypePattern {

	public class Program {

		private static Cell _cell = null;

		private const string SPLIT_BREAK =
			"-----------------------------------------------------";

		public static void Main(string[] args) {
			_cell = new PlantCell(RandomUtil.RandomNum(),
								  "wall",
								  "membrane",
								  "cytoplasm",
								  "nucleus");

			var plant = _cell.Division();

			Console.WriteLine($"_cell.GUID:{_cell.Id},{Environment.NewLine}plant.GUID:{plant.Id}," +
							  $"{Environment.NewLine}equals:{_cell.Id == plant.Id}.");

			Console.WriteLine(SPLIT_BREAK);

			_cell.Content.Mitochondria = "10010101010100101010101";

			Console.WriteLine($"_cell.Content.Mitochondria:{_cell.Content.Mitochondria},{Environment.NewLine}" +
							  $"plant.Content.Mitochondria:{plant.Content.Mitochondria}," +
							  $"{Environment.NewLine}equals:" +
							  $"{_cell.Content.Mitochondria == plant.Content.Mitochondria}.");

			Console.WriteLine(SPLIT_BREAK);

			var animal = _cell.Clone();

			Console.WriteLine($"_cell.GUID:{_cell.Id},{Environment.NewLine}animal.GUID:{animal.Id}," +
							  $"{Environment.NewLine}equals:{_cell.Id == animal.Id}.");

			Console.WriteLine(SPLIT_BREAK);

			_cell.Content.Mitochondria = "01001010010100101010010";

			Console.WriteLine($"_cell.Content.Mitochondria:{_cell.Content.Mitochondria},{Environment.NewLine}" +
							  $"animal.Content.Mitochondria:{animal.Content.Mitochondria}," +
							  $"{Environment.NewLine}equals:" +
							  $"{_cell.Content.Mitochondria == animal.Content.Mitochondria}.");

			Console.WriteLine(SPLIT_BREAK);

			Console.ReadKey();
		}

	}

}