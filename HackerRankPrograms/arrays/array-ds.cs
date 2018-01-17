using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms.arrays
{
    class array_ds
    {
        static void Main23(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            string s = "";
            for (int i = arr.Length; i > 0; i--)
            {
                s += arr[i - 1].ToString() + " ";
            }

            Console.WriteLine(s);
            //Console.Read();
        }
    }
}
