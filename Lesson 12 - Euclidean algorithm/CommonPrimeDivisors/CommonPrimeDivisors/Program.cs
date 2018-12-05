using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonPrimeDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1 };
            int[] B = { 1 };
            var result = solution(A,B);
            Console.WriteLine(result);
            Console.ReadLine();
        }
       // D * K = P.
       //D = primarni broj, K = pozitivni int, on mora biti isti za oba broja i kada je onda se povećava brojač za 1
        public static int solution(int[] A, int[] B)
        {
            var count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (FindFirstPrimeFactor(A[i])
                    .SequenceEqual(FindFirstPrimeFactor(B[i])))
                    ++count;
            }
            return count;
        }

        public static HashSet<int> FindFirstPrimeFactor(int a)
        {
            int b;
            HashSet<int> list = new HashSet<int>();
            for (b = 2; a > 1; b++)
            {
                if (a % b == 0)
                {
                    while (a % b == 0)
                    {
                        list.Add(b);
                        a /= b; 
                    }
                }
            }
            return list;               
        }
    }
}
