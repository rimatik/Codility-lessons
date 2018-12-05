using System;
using System.Linq;

namespace CyclicRotation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 8, 9, 7, 6 } ;
            int K = 3;

            var result = solution(A, K);

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }

        public static int[] solution(int[] A, int K)
        {
            if (!(A.Length >= 0 && A.Length <= 100) 
                || !(K >= 0 && K <= 100) || !A.All(x => x >= -1000 && x <= 1000))                
                return A;

            if (K == 0 || A.Length <= 1)
                return A;

            K = K % A.Length;

            if (K == 0)
                return A;

            if (K < 0)
                K = A.Length + K;
         
            Array.Reverse(A, 0, A.Length);
            Array.Reverse(A, 0, K);
            Array.Reverse(A, K, A.Length - K);

            return A;
        }
    }
}
