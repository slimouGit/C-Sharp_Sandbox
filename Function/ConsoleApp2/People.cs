using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstClass
{
    class People
    {
        private int age;
        private string forename;
        private string surname;
        private string eyecolor;

        public People(int age, string forename, string surname, string eyecolor)
        {
            this.age = age;
            this.forename = forename;
            this.surname = surname;
            this.eyecolor = eyecolor;
        }

        public People(int age, string forename, string surname)
        {
            this.age = age;
            this.forename = forename;
            this.surname = surname;
        }

        public void greetingPerson() {
            if (this.eyecolor != null)
            {
                Console.WriteLine("Vorname " + this.forename + ", Nachname " + this.surname + ", Alter: " + this.age + " Jahre, " + "Augenfarbe: " + this.eyecolor);
            }
            else {
                Console.WriteLine("Vorname " + this.forename + ", Nachname " + this.surname + ", Alter: " + this.age + " Jahre");
            }
        }

        public void setAge(int newAge) {
            if (newAge > this.age) {
                newAge = this.age;
                Console.WriteLine("Das Alter von " + this.forename + " wurde nicht geändert");
            }
            this.age = newAge;
        }

        public string getEyeColor() {
            return this.eyecolor;
        }

        public string getAge() {
            return this.age;
        }



    }
}
