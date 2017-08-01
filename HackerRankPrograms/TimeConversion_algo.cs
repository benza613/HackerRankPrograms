using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class TimeConversion_algo
    {
        static string timeConversion(string s)
        {
            //split the time input
            string[] arr = s.Split(':');
            //check and adjust from 1pm to 11pm (12pm is valid)
            if (arr[2].Contains("PM") && (Convert.ToInt32(arr[0])) != 12)
            {
                arr[0] = (Convert.ToInt32(arr[0]) + 12).ToString();
            }
            //check and adjust if 12am .. since not valid
            else if(arr[2].Contains("AM") && (Convert.ToInt32(arr[0])) == 12)
            {
                arr[0] = "00";
            }

            return arr[0] + ":" + arr[1] + ":" + arr[2].Substring(0,2);
        }

        static void Main4(String[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}
