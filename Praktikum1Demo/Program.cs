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
            /*
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
            */


            //Boolean isValid = int.TryParse(Console.ReadLine(), out age);

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 18) Console.WriteLine("Alaealine");
                else Console.WriteLine("Täisealine");
            }
            else
            {
                Console.WriteLine("Parse failed");
            }

            Console.WriteLine("Write: " + age);
        }
    }
}
