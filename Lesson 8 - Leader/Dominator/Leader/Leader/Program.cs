using System;
using System.Linq;

namespace Leader
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {3, 4, 3, 2, 3, -1, 3, 3, 2};
            //int[] A = {};
         
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //public static int solution(int[] A)
        //{
        //    var half = A.Length / 2;
        //    for (var i = 0; i < half + 1; i++)
        //    {
        //        if (A.ToList().Count(x => x == A[i]) > half)
        //            return i;
        //    }
        //    return -1;
        //}

        //public static int solution(int[] A)
        //{


        public static int solution(int[] A)
        {
            var length = A.Length;
            var candidate = 0;
            var count = 0;

            for (var i = 0; i < length; i++)
            {
                if (count == 0) candidate = i;

                if (A[i] == A[candidate]) ++count;
                else --count;
            }

            count = 0;
            for (var i = 0; i < length; i++) if (A[i] == A[candidate]) ++count;
            if (count <= length / 2) return -1;
            return candidate;
        }
    }
}
