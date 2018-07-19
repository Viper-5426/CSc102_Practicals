using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drips
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How often does the tap drip,  in seconds? ");
            string drip = Console.ReadLine();

            double wastePerHour = 3600 / Convert.ToDouble(drip) * 0.00025;
            double wastePerDay = 86400 / Convert.ToDouble(drip) * 0.00025;
            double wastePerWeek = 604800 / Convert.ToDouble(drip) * 0.00025;

            Console.WriteLine(wastePerHour + " litres of water is wasted every hour");
            Console.WriteLine(wastePerDay + " litres of water is wasted every day");
            Console.WriteLine(wastePerWeek + " litres of water is wasted every week");

            Console.Read();
        }
    }
}