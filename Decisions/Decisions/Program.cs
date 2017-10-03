﻿using System;
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
            int age; 

            Console.WriteLine("Bitte ein Alter eingeben:");
            string input = Console.ReadLine();

            bool convertSuccess = Int32.TryParse(input, out age)


                if (convertSuccess) {
                    testAge(age);
                    Console.Read();
                } 
                

            
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
            else
            {
                Console.WriteLine("alles erlaubt, aber nicht gesund");
            }
        }
    }
}
