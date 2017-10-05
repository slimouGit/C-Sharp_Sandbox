using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] names = { "Max", "Tina", "Beatrice", "Stefan", "Paula" };

            Console.WriteLine("Numbers: ");

            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine(numbers[i]);
            }

            numbers[0] = 10;
            printIntArray(numbers);

            Console.WriteLine("Namen: ");
            printStringArray(names);

            Console.WriteLine(names.Length);

            Console.Read();

        }

        public static void printStringArray(string[] x) {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }

        public static void printIntArray(int[] x) {
            foreach (int item in x) {
                Console.WriteLine(item);
            }
        }
        
    
    }
}
