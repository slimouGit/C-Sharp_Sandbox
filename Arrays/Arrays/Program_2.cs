using System;

namespace Array
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			manageMoney();
			Console.ReadLine();
		}

		public static void manageMoney() {

			double[] assetArray = new double[31];
			double capacity = 0;
			assetArray[0] = 0;
			double percentage = 1.07;

			Console.WriteLine("Wieviel möchtest Du monatlich invesieren");

			string inputInvest = Console.ReadLine();
			int invest = Int32.Parse(inputInvest);
			double annualInvest = Convert.ToDouble(invest) * 12;

			for (int i = 1; i <= 30; i++) {
				assetArray[i] = (assetArray[i] - 1 + annualInvest) * percentage;
			}

			Console.WriteLine("Für wieviel Jahre soll das Vermögen berechnet werden?");

			string annualCount = Console.ReadLine();
			int annualCount_Int = Int32.Parse(annualCount);

			//Kaufkraft berechnen
			capacity = assetArray[annualCount_Int] * (1/(Math.Pow((1.025), annualCount_Int)));

			Console.WriteLine("Das Vermögen nach " + annualCount + " Jahren ist: {0:0.00} €", assetArray[annualCount_Int]);
			Console.WriteLine("Die Kaufkraft nach " + annualCount + " Jahren ist: {0:0.00} €", capacity);

		}
	}
}
