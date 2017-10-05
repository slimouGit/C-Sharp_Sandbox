using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstClass
{
    class Program
    {
        static void Main(string[] args)
        {

            People mimi = new People(41, "Mimi", "Illmi", "blau");
            mimi.setAge(44);

            mimi.greetingPerson();

            People max = new People(28, "Max", "Mustermann");
            max.greetingPerson();

            People salim = new People(37, "Salim", "Oussayfi", "braun");
            salim.greetingPerson();

            

            Console.WriteLine(mimi.getEyeColor());

            Console.ReadLine();
        }
    }
}
