using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class DpSumMaximise
    {
        //Given a positive integer n, break it into the sum of at least two positive integers and maximize the product of those integers.Return the maximum product you can get.
        //For example, given n = 2, return 1 (2 = 1 + 1); given n = 10, return 36 (10 = 3 + 3 + 4).

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            //lol 
            if (n == 2 || n == 3)
            {
                Console.WriteLine(n - 1);
            }
            else
            {
                while (n > 4)
                {
                    //reduce n
                    n -= 3;
                    // since n is always greater than 4.
                    result *= 3;
                }
                // take remainder of n
                Console.WriteLine(n * result);
            }
        }

    }
}
