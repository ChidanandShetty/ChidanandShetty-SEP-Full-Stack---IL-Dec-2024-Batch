using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Greeting
    {
        static void Main()
        {
            // Use DateTime.Now for real-time greeting
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour; // Get the current hour

            // Determine the appropriate greeting using only if statements
            if (hour >= 5 && hour < 12)
                Console.WriteLine("Good Morning");
            if (hour >= 12 && hour < 17)
                Console.WriteLine("Good Afternoon");
            if (hour >= 17 && hour < 21)
                Console.WriteLine("Good Evening");
            if ((hour >= 21 && hour <= 23) || (hour >= 0 && hour < 5))
                Console.WriteLine("Good Night");

            // Display current time (optional)
            Console.WriteLine($"Current Time: {currentTime:hh:mm tt}");
        }
    }
}
