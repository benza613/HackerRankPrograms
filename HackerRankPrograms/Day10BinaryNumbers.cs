using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class Day10BinaryNumbers
    {
        static void Main6(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            // Initialize result
            int count = 0;

            // Count the number of iterations to
            // reach n = 0.
            while (n != 0)
            {
                // This operation reduces length
                // of every sequence of 1s by one.
                n = (n & (n << 1));
                count++;
            }

            Console.WriteLine(count);

        }
    }
}
