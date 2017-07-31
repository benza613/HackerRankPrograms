using System;
using System.Collections.Generic;

namespace HackerRankPrograms
{
    public class Stats10days0
    {
        public class sortedMode
        {
            public int count { get; set; }
            public int item { get; set; }

            public sortedMode(int c, int it)
            {
                count = c;
                item = it;
            }
        }

        public static List<sortedMode> s { get; set; }

        public float[] Result(int[] unsorted)
        {
            Array.Sort(unsorted);
            float[] output = new float[3];
            int sum = 0;
            int matchFound = 0;

            s = new List<sortedMode>();

            for (int inpElem = 0; inpElem < unsorted.Length; inpElem++)
            {
                //take sum 
                sum += unsorted[inpElem];

                //check in existing object for matching element
                for (int i = 0; i < s.Count; i++)
                {
                    //till match not found set flag to 0
                    if (s[i].item != unsorted[inpElem])
                    {
                        matchFound = 0;
                    }
                    else
                    {
                        matchFound = 1;
                        s[i].count++;
                        break;
                    }
                }

                if (matchFound == 0)
                {
                    s.Add(new sortedMode(1, unsorted[inpElem]));
                }
            }

            float median = 0;
            if (unsorted.Length % 2 == 0)
            {
                median = (unsorted[unsorted.Length / 2] + unsorted[(unsorted.Length / 2) - 1]) / (float)2;
            }
            else
            {
                median = unsorted[unsorted.Length / 2];
            }


            int greatestModeItem = 0;
            int greatestMode = 0;

            //check in existing object for greatest mode element
            for (int i = 0; i < s.Count; i++)
            {
                if (greatestMode < s[i].count)
                {
                    greatestMode = s[i].count;
                    greatestModeItem = s[i].item;
                }
            }

            output[0] = sum / (float)unsorted.Length;
            output[1] = median;
            output[2] = greatestModeItem;

            return output;

        }
    }
}
