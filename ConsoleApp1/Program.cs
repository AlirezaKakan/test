using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Park parking = new Park();

            Console.WriteLine(parking.Available(2));

            Console.ReadKey();
        }
    }
}
