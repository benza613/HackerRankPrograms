using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class DiagonalDiff_algo
    {
        //current rank 431682
        static void Main3(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int sum_diag1 = 0;
            int sum_diag2 = 0;

            for(int i= 0; i < n; i++)
            {
                sum_diag1 += a[i][i];
                sum_diag2 += a[i][n-i-1];
            }

            Console.WriteLine(Math.Abs(sum_diag1 - sum_diag2));
        }
    }
}
