using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms.arrays
{
    class dynamic_array
    {
        static void Main(String[] args)
        {
            int lastnumber = 0;

            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int N = arr[0];
            int queries = arr[1];

            //PROBLEM : https://www.hackerrank.com/challenges/dynamic-array/problem

            List<List<int>> seq = new List<List<int>>();
            for (int i = 0; i < N; i++)
            {
                seq[i] = new List<int>();
            }

            int[][] data = new int[queries][];
            for (int arr_i = 0; arr_i < queries; arr_i++)
            {
                string[] arr_tempx = Console.ReadLine().Split(' ');
                data[arr_i] = Array.ConvertAll(arr_tempx, Int32.Parse);
            }

            foreach (var query in data)
            {
                int qt = query[0];
                int x = query[1];
                int y = query[2];

                if (qt == 1)
                {
                    int seq_num = ((x ^ lastnumber) % N);
                    seq[seq_num].Add(y);
                }
                else
                {
                    int seq_num = ((x ^ lastnumber) % N);
                    lastnumber = seq[seq_num][y];
                    Console.WriteLine(lastnumber);
                }
            }
            Console.Read();
        }
    }
}
