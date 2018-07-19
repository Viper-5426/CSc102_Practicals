using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How often does the tap drip, in seconds? ");
            string drip = Console.ReadLine();

            double wastePerDay = 86400 / Convert.ToDouble(drip) * 0.00025;
            double fullGlasses = Convert.ToInt16(wastePerDay * 4);

            Console.WriteLine(fullGlasses + " full glasses are wasted everyday");

            Console.Read();
        }
    }
}