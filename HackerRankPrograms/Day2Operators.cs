using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms
{
    class Day2Operators
    {
        static void Main5(String[] args)
        {
            decimal mealCost = decimal.Round(Convert.ToDecimal(Console.ReadLine()),2,MidpointRounding.ToEven);
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            int taxPercent = Convert.ToInt32(Console.ReadLine());

            decimal tip = mealCost *( tipPercent / (decimal)100);
            decimal tax = mealCost *( taxPercent / (decimal)100);
            decimal totalCost = mealCost + tip + tax;

            Console.WriteLine("The total meal cost is "+ Convert.ToInt32(totalCost) + " dollars.");
        }
    }
}
