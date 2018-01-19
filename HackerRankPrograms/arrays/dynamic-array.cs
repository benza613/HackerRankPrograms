using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPrograms.arrays
{
    class dynamic_array
    {
        static void Main36(String[] args)
        {
            //solution inspired by jwang1004
            int[] para = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int N = para[0];
            int Q = para[1];
            List<int>[] lists = new List<int>[N];
            for (int i = 0; i < N; i++)
            {
                lists[i] = new List<int>();
            }

            int[][] queries = new int[Q][];
            for (int i = 0; i < Q; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            }
            int lastans = 0;
            for (int i = 0; i < Q; i++)
            {
                lastans = doQuery(lists, N, queries[i], lastans);
            }

        }
        static int doQuery(List<int>[] lists, int N, int[] query, int lastans)
        {
            int x = query[1];
            int y = query[2];
            int n = (x ^ lastans) % N;
            if (query[0] == 1)
            {
                lists[n].Add(y);
                return lastans;
            }
            else if (query[0] == 2)
            {
                int size = lists[n].Count;
                int res = lists[n][y % size];
                Console.WriteLine(res);
                return res;
            }
            return lastans;
        }

        


    }
}
