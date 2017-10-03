using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class TryParse
    {
        static void Main(string[] args)
        {
            int age; 

            Console.WriteLine("Bitte ein Alter eingeben:");
            string input = Console.ReadLine();

            bool convertSuccess = Int32.TryParse(input, out age)


                if (convertSuccess) {
                Console.WriteLine("Success");
                    Console.Read();
                } 
                

            
        }
    }
}
