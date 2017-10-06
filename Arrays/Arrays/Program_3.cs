using System;

namespace Array_Lesson
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			for (int i = 0; i < numbers.Length; i++) {
				Console.WriteLine(numbers[i]);
			};

			string[] names = { "Fritz", "Tina", "Anton", "Beatrice" };

			Console.WriteLine("Anzahl: " + names.Length);

			foreach (string item in names) { 
				Console.WriteLine(item);
			}

			names[0] = "Hannah";

			printStringArray(names);

			//--------------------------------------------------------------

			string[,] studentMatrix = { { "Fritz", "Tina", "Anton", "Beatrice" }, { "Medieninformatik", "Informatik", "Wirtschaftsinformatik", "Mathematik" } };

			Console.WriteLine(studentMatrix.Length);

			Console.WriteLine(studentMatrix[0, 0]);
			Console.WriteLine(studentMatrix[1, 0]);

			//--------------------------------------------------------------

			Console.Read();
		}

		public static void printStringArray(string[] x) {
			Console.WriteLine("Print Array:" );
			foreach (string item in x)
			{
				Console.WriteLine(item);
			}
		}
	}
}
