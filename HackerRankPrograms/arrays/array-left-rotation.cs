using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms.arrays
{
    class array_left_rotation
    {
        static int[] leftRotation(int[] arr, int shift)
        {
            // Complete this function
            shift = shift % arr.Length;
            int[] buffer = new int[shift];
            Array.Copy(arr, buffer, shift);
            Array.Copy(arr, shift, arr, 0, arr.Length - shift);
            Array.Copy(buffer, 0, arr, arr.Length - shift, shift);
            return arr;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int d = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] result = leftRotation(a, d);
            Console.WriteLine(String.Join(" ", result));
            Console.Read();


        }

    }
}
