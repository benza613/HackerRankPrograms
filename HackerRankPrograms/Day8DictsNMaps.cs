using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class Day8DictsNMaps
    {
        static void Main2(String[] args)
        {
            //fix input 
            int n = Convert.ToInt32(Console.ReadLine());
            //declare output 
            List<string> res = new List<string>();
            //prepare input data holder
            Dictionary<string, string> d = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] u = Console.ReadLine().Split(' ');
                d.Add(u[0], u[1]);
            }

            string lookup;
            //lookup each line in dict
            while ((lookup = Console.ReadLine()) != null)
            {
                // Do whatever you want here with lookup
                if (d.ContainsKey(lookup))
                {
                    res.Add(lookup + "=" + d[lookup]);
                }
                else
                {
                    res.Add("Not found");
                }
            }

            //print unknown length output 
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
