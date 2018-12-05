using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNonoverlappingSegments
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 1, 3, 7, 9, 9 };
            //int[] B = { 5, 6, 8, 9, 10 };
            int[] A = { };
            int[] B = { };
            var result = solution(A,B);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] A, int[] B)
        {
            var length = A.Length;
           
            var count = 0;
            if (length > 0 && B.Length > 0)
            {
                var b = B[0];
                for (int i = 0; i < length; i++)
                {

                    if (i + 1 < length && A[i + 1] > b && B[i + 1] > b)
                    {
                        ++count;
                        b = B[i + 1];
                    }
                }
                ++count;

            }
            return count;
        }
    }
}
