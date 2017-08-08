using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class Day6Strings
    {
        static void Main2(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                char[] arr1 = arr[i].ToCharArray();
                char[] res = new char[arr1.Length + 1];
                int counter = 0;
                for (int j = 0; j < arr1.Length; j = j + 2)
                {
                    res[counter] = arr1[j];
                    counter++;
                }

                res[counter] = ' ';
                counter++;

                for (int j = 1; j < arr1.Length; j = j + 2)
                {
                    res[counter] = arr1[j];
                    counter++;
                }

                Console.WriteLine(res);
            }
        }
    }
}
