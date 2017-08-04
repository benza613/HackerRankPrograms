using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class Day3ConditionalStatements
    {
        static void Main6(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string result = "";
            if (n % 2 == 1)
            {
                result = "Weird";
            }
            else
            {
                if(n >= 2 && n <= 5)
                {
                    result = "Not Weird";
                }
                else if(n >= 6 && n <= 20)
                {
                    result = "Weird";
                }
                else
                {
                    result = "Not Weird";
                }
            }


            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
