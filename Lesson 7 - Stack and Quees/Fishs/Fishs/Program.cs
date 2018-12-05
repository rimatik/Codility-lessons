using System;
using System.Collections.Generic;

namespace Fishs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 6, 5, 4, 7, 9, 8 };
            int[] B = { 0, 1, 1, 0, 0, 1 };

            var result = solution(A, B);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static int solution(int[] A, int[] B)
        {
            Stack<int> aliveFishes = new Stack<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (aliveFishes.Count == 0)
                {
                    aliveFishes.Push(i);
                }
                else
                {
                    while (aliveFishes.Count != 0
                             && B[i] - B[aliveFishes.Peek()] == -1
                             && A[aliveFishes.Peek()] < A[i])
                    { aliveFishes.Pop(); }

                    if (aliveFishes.Count != 0)
                    { if (B[i] - B[aliveFishes.Peek()] != -1) aliveFishes.Push(i); }

                    else { aliveFishes.Push(i); }
                }
            }
            return aliveFishes.Count;
        }
    }
}

