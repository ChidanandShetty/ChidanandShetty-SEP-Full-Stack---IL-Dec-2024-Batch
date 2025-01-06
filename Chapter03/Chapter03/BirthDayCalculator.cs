using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class BirthDayCalculator
    {
        static void Main()
        {
            // Define birthdate (Change this to your birthdate)
            DateTime birthDate = new DateTime(1995, 1, 1); // Example: Jan 1, 1995

            // Get today's date
            DateTime today = DateTime.Today;

            // Calculate age in days
            int daysOld = (today - birthDate).Days;

            // Calculate next 10,000-day anniversary
            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);

            // Display results
            Console.WriteLine($"You are {daysOld} days old.");
            Console.WriteLine($"Your next 10,000-day anniversary is on {nextAnniversary:MMMM dd, yyyy}");
        }
    }
}
