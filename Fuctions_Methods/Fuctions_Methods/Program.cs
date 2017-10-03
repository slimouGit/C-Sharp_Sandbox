using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuctions_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string alternateString = "hello univers";
            schreibeText("hello world");
            schreibeText(alternateString);

            Console.WriteLine(addValues(2, 5));
            int ergebnis2 = addValues(15, 2);

            Console.WriteLine(ergebnis2);

            string nameFriend = Console.ReadLine();
            greetingFriend(nameFriend);


            addOwnValues();

            Console.Read();
        }

       

        public static void schreibeText(string input)
        {
            Console.WriteLine("first output " + input);            
        }

        public static int addValues(int a, int b) {
            int sum = a + b;
            return sum;
        }

        public static void greetingFriend(string name)
        {
            Console.WriteLine("Hallo " + name);
        }

        public static void addOwnValues() {
            Console.WriteLine("Bitte eine Zahl eingeben");
            string a = Console.ReadLine();
            Console.WriteLine("Bitte eine zweite Zahl eingeben");
            string b = Console.ReadLine();
            int valueA = Convert.ToInt32(a);
            int valueB = Convert.ToInt32(b);
            int sum = valueA + valueB;
            Console.WriteLine("Das Ergebnis lautet: " + sum);
        }

    }
}
