using System;

namespace Classes {

	class Auto
	{
		private int hp;
		private string brand, modell, color;

		public Auto(string brand, string model, int hp)
		{
			this.brand = brand;
			this.modell = model;
			this.hp = hp;		
		}

		public void setColor(string color) { 
			this.color = color;
		}

		public string getColor()
		{
			return color;
		}

		public void printInformation() {
			if (color != null)
			{
				Console.WriteLine("Fahrzeug " + this.brand + " " + this.modell + ", PS: " + this.hp + ", Farbe: " + this.color);
			}
			else {
				Console.WriteLine("Fahrzeug " + this.brand + " " + this.modell + ", PS: " + this.hp);
			}
		}
	}
}
