using System;


namespace Lesson_1._3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input first line");
			string firstLine = Console.ReadLine().ToUpper();

			//Console.WriteLine($"{firstLine}");

			Console.WriteLine("Input second line");
			String secondLine = Console.ReadLine().ToUpper();

			Console.WriteLine("Input third line");
			string thirdLine = Console.ReadLine().ToUpper();

			//var firstStringFromThird =
			bool result1 = firstLine.StartsWith(secondLine);
			bool result2 = firstLine.EndsWith(thirdLine);

			Console.WriteLine($"String {firstLine} starts from {secondLine}:{result1}");
			Console.WriteLine($"String {firstLine} ends with {thirdLine}:{result2}");

			Console.ReadKey();
		}
	}
}
