using System;
using System.CodeDom;
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
            int age = 0;
            try
            {
                age = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Tekkis viga" + e);
                throw;
            }

            if (age < 18)
            {
                Console.WriteLine("Alaealine");
            }

            Console.WriteLine("Write: " + age);
        }
    }
}
