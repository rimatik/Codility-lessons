using System;

namespace Stones
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 8, 8, 5, 7, 9, 8, 7, 4, 8 };
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] H)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var L = H.Length;
            var stones = 0;
            var wall = new int[L];
            var wallNum = 0;

            for (var i = 0; i < L; i++)
            {
                while (wallNum > 0 && wall[wallNum - 1] > H[i]) wallNum -= 1;
                if (wallNum > 0 && wall[wallNum - 1] == H[i]) continue;
                stones += 1;
                wall[wallNum] = H[i];
                wallNum += 1;
            }
            return stones;
        }
    }
}
