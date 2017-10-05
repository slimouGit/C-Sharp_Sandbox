using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Session
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList students = new ArrayList();
            students.Add("Hans");
            students.Add("Petra");
            students.Add("Meike");
            students.Add("Paul");

            students.Remove("Hans");
            students.RemoveAt(1);

            Console.WriteLine(students.Count);

            Console.Read();

        }
    }
}
