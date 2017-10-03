using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class testAge
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte ein Alter eingeben:");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            testAge(age);

            Console.Read();
        }

        public static void testAge(int age)
        {
            if (age < 16)
            {
                Console.WriteLine("Kein Alkohol erlaubt");
            }
            else if (age < 18)
            {
                Console.WriteLine("nur Bier und Wein ist erlaubt");
            }
            else {
                Console.WriteLine("alles erlaubt, aber nicht gesund");
            }
        }
    }
}
