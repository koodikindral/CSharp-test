using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // CTRL + F5  / F5 (debugging)
            Console.WriteLine("Palun sisestage vanus");
            
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Alaealine");
            }

            Console.WriteLine("Write: " + age);
        }
    }
}
