using System;

namespace Exceptions
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Wie alt bist Du");

			string input = Console.ReadLine();

			try
			{
				int age = Int32.Parse(input);
				Console.WriteLine("Du bist " + input + " Jahre alt");
			}
			catch (Exception e)
			{
				Console.WriteLine(input + " ist keine Zahl – " + e.Message);
			}
			finally {
				Console.WriteLine("Programm beendet");
			}


			Console.Read();
		}
	}
}
