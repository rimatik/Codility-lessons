using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAbsSumOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { -8, 4, 5, -10, 3 };
            Array.Sort(A);
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        //public static int solution(int[] A)
        //{
        //    var length = A.Length;
        //    var min = 0;
        //    var check = 0;
        //    for (int i = 0; i < length; i++)
        //    {              
        //        for (int j = 0; j < length; j++)
        //        {
        //            if (i == 0 && j == 0)
        //                min = Math.Abs(A[i] + A[j]);
        //            else
        //            {
        //                check = Math.Abs(A[i] + A[j]);
        //                if (check < min)
        //                    min = check;
        //            }
        //        }
        //    }
        //    return min;
        //}

        public static int solution(int[] A)
        {
                Array.Sort(A);
                int minAbsSum = int.MaxValue;
                int back = A.Length - 1;
                int front = 0;
                while (front <= back)
                {
                    int currentSum = Math.Abs(A[front] + A[back]);
                    minAbsSum = Math.Min(currentSum, minAbsSum);
                    if (front + 1 < A.Length && Math.Abs(A[front + 1] + A[back]) <= currentSum)
                        front++;
                    else if (back > 0 && Math.Abs(A[front] + A[back - 1]) <= currentSum)
                        back--;
                    else
                    {
                        back--;
                        front++;
                    }
                }

                return minAbsSum;
        }
    }
}
