using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string eventName = "";
            eventName = Console.ReadLine();

            if (eventName == "Kino")
            {
                Console.WriteLine("hebe 25 Euro ab");
            }
            if (eventName == "Konzert")
            {
                Console.WriteLine("hebe 80 Euro ab");
            }
            if (eventName == "")
            {
                Console.WriteLine("hebe 10 Euro ab");
            }

            string temperaturString = Console.ReadLine();
            int temperatur = Convert.ToInt32(temperaturString);
            whatforCloses(temperatur);

            Console.Read();
        }

        public static void whatforCloses(int temperatur) {
            Console.WriteLine("Temperatur ist: " + temperatur);
        }
    }
}
