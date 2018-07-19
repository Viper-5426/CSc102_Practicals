using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How often does the tap drip,  in seconds? ");
            string drip = Console.ReadLine();
            int iDrips = 0;

            if (Int32.TryParse(drip, out iDrips))
            {
                Console.WriteLine("Your input is valid");
            }
            else
            {
                Console.WriteLine("Your input is invalid");
            }

            Console.Read();

        }
    }
}