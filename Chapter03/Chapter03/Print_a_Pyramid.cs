using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Print_a_Pyramid
    {
        static void Main()
        {
            int rows = 5; // Change this to adjust pyramid height

            for (int i = 1; i <= rows; i++)
            {
                // Print spaces
                for (int j = 1; j <= rows - i; j++)
                    Console.Write(" ");

                // Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");

                Console.WriteLine(); // Move to the next line
            }
        }
    }
}
