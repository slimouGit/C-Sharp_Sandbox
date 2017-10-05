using System;
namespace Inheritance
{
	public class Trainee : Employee
	{	

		private int workhour, schoolhour;

		public Trainee(int workhour, int schoolhour, string forename, string surname, int salary) : base(forename, surname, salary)
		{
			this.workhour = workhour;
			this.schoolhour = schoolhour;
		}

		public void lerning()
		{
			Console.WriteLine("Ich lerne " + this.schoolhour + " Stunden");
		}

		public void working()
		{
			Console.WriteLine("Ich bin " + this.workhour + " Stunden am arbeiten");
		}

	}
}
