using System;

namespace HackerRankPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] u = Console.ReadLine().Split(' ');
            int[] unsortedInt = Array.ConvertAll(u, Int32.Parse);

            

            float[] r = new Stats10days0().Result(unsortedInt);

            c(r[0].ToString("0.0"));
            c(r[1].ToString());
            c(r[2].ToString());
        }

        static void c(string s)
        {
            Console.WriteLine(s);
        }
    }
}
