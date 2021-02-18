using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input first line");
			string firstLine = Console.ReadLine();

			Console.WriteLine("Input second line");
			String secondLine = Console.ReadLine();

			Console.WriteLine("Input symbol");
			char symbol = Console.ReadKey().KeyChar;

			string concatOfSrings = firstLine +  secondLine;
			int indexOfChar = concatOfSrings.LastIndexOf(symbol);

			Console.WriteLine($"\r\nIndex of {symbol} in {concatOfSrings}:{indexOfChar}");

			Console.ReadKey();
		}
	}
}
