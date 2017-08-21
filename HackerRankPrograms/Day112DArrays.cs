using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class Day112DArrays
    {
        static void Main3(String[] args)
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            int res = 0;

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    int outp = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    //WHY ? the result comparison bounding must begin from first i0 and j0 AND NOT from value 0.
                    if (i == 0 && j == 0)
                    {
                        res = outp;
                    }
                    res = outp > res ? outp : res;
                }
            }

            Console.WriteLine(res);
        }
    }
}
