using System;
using System.Collections.Generic;
using System.Linq;

namespace MinAvgTwoSlice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 4, 2, 2, 5, 1, 5, 8 };
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //It checks the average of all subarrays formed with 2 elements and 3 elements.
        //Any group of more elements will have an average >= to one of these groups, so the smaller group would be optimal.
        public static int solution(int[] A)
        {            
            int minIndex = 0;
            double minAvgVal = double.MaxValue;

            for (int i = 0; i < A.Length - 2; i++)
            {
                double twoDigitMin = (A[i] + A[i + 1]) / 2.0;
                if (minAvgVal > twoDigitMin)
                {
                    minAvgVal = twoDigitMin;
                    minIndex = i;
                }

                double threDigitMin = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                if (minAvgVal > threDigitMin)
                {
                    minAvgVal = threDigitMin;
                    minIndex = i;
                }
            }

            double last2Avg = (A[A.Length - 2] + A[A.Length - 1]) / 2.0;
            if (minAvgVal > last2Avg)
            {
                minIndex = A.Length - 2;
            }

            return minIndex;
        }
    }
}
