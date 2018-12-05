using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSliceSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {3,2,-6,4,0};
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            var maxEnding = A[0];
            var maxSoFar = A[0];
            for (int index = 1; index < A.Length; index++)
            {
                maxEnding = Math.Max(A[index], maxEnding + A[index]);
                maxSoFar = Math.Max(maxSoFar, maxEnding);
            }
            return maxSoFar;
        }
    }
}
