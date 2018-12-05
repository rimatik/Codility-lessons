using System;

namespace MaxSliceProblem
{
    class Program
    {
        static void Main(string[] args)
        {
        //int[] A = { 3, 2, -1, 4, 5};
            int[] A = {6, 1, 5, 6, 4, 2, 9, 4};

             //[6, 1, 5, 6, 4, 2, 9, 4]

        var result = solution(A);
        Console.WriteLine(result);
        Console.ReadLine();

        }

        public static int solution(int[] A)
        {
            int N = A.Length;
            int[] K1 = new int[N];
            int[] K2 = new int[N];

            for (int i = 1; i < N - 1; i++)
            {
                K1[i] = Math.Max(K1[i - 1] + A[i], 0);
            }
            for (int i = N - 2; i > 0; i--)
            {
                K2[i] = Math.Max(K2[i + 1] + A[i], 0);
            }

            int max = 0;

            for (int i = 1; i < N - 1; i++)
            {
                max = Math.Max(max, K1[i - 1] + K2[i + 1]);
            }

            return max;
        }
    }
}
