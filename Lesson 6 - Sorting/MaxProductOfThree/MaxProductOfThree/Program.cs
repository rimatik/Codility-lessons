using System;

namespace MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = {-5, 5, -5, 4};
            var result = solution(A);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            Array.Sort(A);
           
            var length = A.Length;
            var result = A[length - 1]*A[length - 2]*A[length - 3];
            var firstTwoMaxProd = A[0]*A[1]*A[length - 1];
            return firstTwoMaxProd > result ? firstTwoMaxProd : result;
        }
    }
}
