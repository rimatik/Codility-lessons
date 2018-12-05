using System;
using System.Collections.Generic;
using System.Linq;

namespace FrogRiverOne
{
    class Program
    {
        //HashSet ima O(1) za count i contains
        static void Main(string[] args)
        {
            int X = 5;
            int[] A = {1, 2, 3, 4, 1, 2};
            var result = solution(X, A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int X, int[] A)
        {
            HashSet<int> list = new HashSet<int>();
            
            for (int i = 0; i < A.Length; i++)
            {
                if (!list.Contains(A[i]))
                    list.Add(A[i]);

                if (list.Count() == X)
                    return i;
            }
            return -1;
        }
    }
}
