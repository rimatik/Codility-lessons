using System;

namespace NumberOfDiscIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 5, 2, 1, 4, 0 };
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int solution(int[] A)
        {            
            int n = A.Length;
            int numIntersecs = 0;
            for (long i = 0; i < n - 1; i++)
                for (long j = i + 1; j < n; j++)
                    if (i - A[i] <= j + A[j] && j - A[j] <= i + A[i]) 
                        if (numIntersecs == 10E6)
                            return -1;
                        else
                            numIntersecs++;
            return numIntersecs;
        }
    }
}
