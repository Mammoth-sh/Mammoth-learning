using System;


namespace Lesson_1
{
	class Program
	{
		static void Main()
		{
			
			Console.WriteLine("Input X");
			int x = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Input Y");
			int y = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Input Z");
			int z = Convert.ToInt32(Console.ReadLine());

			var zpower = (Math.Pow(z, 2));
			var res1 = (x + y)*(zpower+1); 
			//var res266 = (x + y) * (Math.Pow(z, 2)+1); 
			Console.WriteLine($"First expression result: {res1}");

			var res2 = ((x % z)-1) * Math.Sqrt(y); 
			Console.WriteLine($"Second expression result: {res2}");

			var zpower3 = (Math.Pow(z, 3));
			var res3 = ((x*y)+(y*z))/zpower3;
			Console.WriteLine($"Second expression result: {res3}");

			Console.ReadKey();
		}
	}
}
