using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GenomicRangeQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "CAGCCTA";
            int[] P = { 2,5,0 };
            int[] Q = { 4,5,6 };
            var result = solution(S,P,Q);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        //62%
        //public static int[] solution(string S, int[] P, int[] Q)
        //{
        //    List<int> listToReturn = new List<int>();

        //    for (int i = 0; i < P.Length; i++)
        //    {
        //        int min = 0;
        //        var diffRange = Q[i] - P[i] + 1;

        //        var substring = S.Substring(P[i], diffRange);

        //        if (Regex.Match(substring, "T").Value == "T") min = 4;

        //        if (Regex.Match(substring, "G").Value == "G") min = 3;

        //        if (Regex.Match(substring, "C").Value == "C") min = 2;

        //        if (Regex.Match(substring, "A").Value == "A") min = 1;

        //        listToReturn.Add(min);
        //    }
        //    return listToReturn.ToArray();
        //}

        //100%
        public static int[] solution(String S, int[] P, int[] Q)
        {

            int[,] genoms = new int[3,S.Length + 1];

            short a, c, g;
            for (int i = 0; i < S.Length; i++)
            {
                a = 0; c = 0; g = 0;
                if ('A' == S[i])
                {
                    a = 1;
                }
                if ('C' == S[i])
                {
                    c = 1;
                }
                if ('G' == S[i])
                {
                    g = 1;
                }

                genoms[0,i + 1] = genoms[0,i] + a;
                genoms[1,i + 1] = genoms[1,i] + c;
                genoms[2,i + 1] = genoms[2,i] + g;
            }

            int[] result = new int[P.Length];

            for (int i = 0; i < P.Length; i++)
            {
                int fromIndex = P[i];

                int toIndex = Q[i] + 1;
                if (genoms[0,toIndex] - genoms[0,fromIndex] > 0)
                {
                    result[i] = 1;
                }
                else if (genoms[1,toIndex] - genoms[1,fromIndex] > 0)
                {
                    result[i] = 2;
                }
                else if (genoms[2,toIndex] - genoms[2,fromIndex] > 0)
                {
                    result[i] = 3;
                }
                else
                {
                    result[i] = 4;
                }
            }

            return result;
        }
    }
}


