using System;
namespace Inheritance
{
	public class Superior : Employee
	{	
		private string companyCar;

		public Superior(string companyCar, string forename, string surname, int salary) : base(forename, surname, salary)
		{
			this.companyCar = companyCar;
		}

		public void rule(Employee employee) {
			Console.WriteLine("Ich führe Frau/Herr " + employee.Name + "!");
		}
	}
}
