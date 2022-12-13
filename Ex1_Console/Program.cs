using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Ex1_Console {
	class Program {
		static void Main(string[] args) {
			string str = string.Empty;

			while (true){
				Console.Write("Введите предложение: ");
				str = Console.ReadLine();

				if (!string.IsNullOrWhiteSpace(str)) break;
			}

			Regex extractDateRegex = new Regex(@"[0-9]{1,2}.[0-9]{1,2}.[0-9]{4}");

			MatchCollection extracted = extractDateRegex.Matches(str);

			Console.WriteLine($"\nВсе даты, за текущий год [{DateTime.Now.Year}]:");
			foreach (var item in extracted) {
				DateTime date;
				DateTime.TryParse(item.ToString(), out date);

				if (date.Year == DateTime.Now.Year) Console.WriteLine(item.ToString());
			}
		}
	}
}
