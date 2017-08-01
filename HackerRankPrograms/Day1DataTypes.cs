using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class Day1DataTypes
    {
        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            void c(string st)
            {
                Console.WriteLine(st);
            }

            int ri = i + Convert.ToInt32(Console.ReadLine());
            string rds = Console.ReadLine();
            decimal rd = (decimal)d + Convert.ToDecimal(rds);

            string rs = s + Console.ReadLine();

            c(ri.ToString());
            c(rd.ToString("#.0"));
            c(rs.ToString());

            var x = Console.ReadLine();

            
        }

        
    }
}
