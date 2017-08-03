using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class WeightedMean_challenges0
    {
        static void Main6(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] w = new int[n][];
            string[] w_temp = Console.ReadLine().Split(' ');
            w[0] = Array.ConvertAll(w_temp, Int32.Parse);


            int[][] x = new int[n][];
            string[] x_temp = Console.ReadLine().Split(' ');
            x[0] = Array.ConvertAll(x_temp, Int32.Parse);


            int numerator = 0;
            int denominator = 0;

            for (int i = 0; i < n; i++)
            {
                numerator += w[0][i] * x[0][i];
                denominator += x[0][i];
            }

            Console.WriteLine((numerator / (float) denominator).ToString("#.0"));

        }
    }
}
