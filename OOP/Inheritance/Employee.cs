using System;
namespace Inheritance
{
	public class Employee
	{
		private string forename, surname;
		private int salary;

		public string Name
		{ 
			get
			{
				return surname;
			}
			set {
				surname = value;
			}
		}

		public Employee(string forename, string surname, int salary)
		{
			this.forename = forename;
			this.surname = surname;
			this.salary = salary;
		}

		public void working() {
			Console.WriteLine("I bin am arbeiten");
		}

		public void pause() { 
			Console.WriteLine("Ich pausiere");
		}


	}
}
