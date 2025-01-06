using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class IncrementalCounter
    {
        static void Main()
        {
            for (int i = 1; i <= 4; i++) // Outer loop (increment values: 1, 2, 3, 4)
            {
                for (int j = 0; j <= 24; j += i) // Inner loop (counts with step i)
                {
                    Console.Write(j);
                    if (j + i <= 24) Console.Write(","); // Add comma except for last number
                }
                Console.WriteLine(); // New line after each sequence
            }
        }
    }
}
