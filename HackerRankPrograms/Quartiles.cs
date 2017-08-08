using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class Quartiles
    {
        //solution pending
        static void Main3(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] u = Console.ReadLine().Split(' ');
            int[] x = Array.ConvertAll(u, Int32.Parse);

            // we sorted the array from low to high
            Array.Sort(x);

            int[] res = new int[3];
            int upper = 0;
            int lower = 0;

            int[] up;
            int[] low;

            //if even number of elements
            if (x.Length % 2 == 0)
            {
                res[1] = (x[x.Length / 2] + x[(x.Length / 2) - 1]) / 2;
                lower = (x.Length / 2) - 1;
                upper = x.Length / 2;

            }
            else
            {
                res[1] = x[x.Length / 2];
                lower = (x.Length / 2) - 1;
                upper = (x.Length / 2) + 1;
            }

            Console.WriteLine(res[1]);

            low = new int[lower + 1];
            up = new int[n - upper];

            for(int i= 0; i <= lower; i++)
            {
                low[i] = x[i];
                up[i] = x[i + upper];
            }




            //now check for lower is even or odd 
            if (low.Length % 2 == 0)
            {
                res[0] = (low[low.Length / 2] + x[(low.Length / 2) - 1]) / 2;
            }
            else
            {
                res[0] = x[low.Length / 2];
            }

            //now check for upper is even or odd 
            if (up.Length % 2 == 0)
            {
                res[2] = (x[up.Length / 2] + x[(up.Length / 2) - 1]) / 2;
            }
            else
            {
                res[2] = x[up.Length / 2];
            }

            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.WriteLine(res[2]);

            Console.ReadKey();
        }
    }
}
