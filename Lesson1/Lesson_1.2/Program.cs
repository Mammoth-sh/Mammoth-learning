using System;


namespace Lesson_1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input length");
			int length = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Input width");
			int width = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Input height");
			int height = Convert.ToInt32(Console.ReadLine());

			var diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2) + Math.Pow(height, 2));
			Console.WriteLine($"Parallelepiped diagonal lengt: {diagonal}");

			Console.ReadKey();
		}
	}
}
