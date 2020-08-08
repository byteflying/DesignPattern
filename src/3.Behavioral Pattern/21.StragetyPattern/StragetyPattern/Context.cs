using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StragetyPattern {

	public class Context {

		private Tax _tax = null;

		private const decimal EXEMPTION_VALUE = 3500m;

		private List<decimal> _taxLevel = new List<decimal>{
			0,
			1500,
			4500,
			9000,
			35000,
			55000,
			80000,
			decimal.MaxValue
		};

		private List<Type> _levels = new List<Type>();

		private void GetLevels() {
			_levels = AppDomain.CurrentDomain.GetAssemblies()
							   .SelectMany(tp => tp.GetTypes()
							   .Where(t => t.BaseType == typeof(Tax)))
							   .ToList();
		}

		public Context() {
			GetLevels();
		}

		public Context Calculate(decimal income) {
			_tax = new Level0();
			var result = income - EXEMPTION_VALUE;
			for(int i = 1; i <= _taxLevel.Count - 1; i++) {
				if(result > _taxLevel[i - 1] && result <= _taxLevel[i]) {
					_tax = (Tax)Activator.CreateInstance(_levels[i]);
				}
			}
			Console.WriteLine($"Income = {income}," + $"tax = {_tax.Calculate(result)}!");
			return this;
		}

	}

}