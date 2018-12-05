using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TieRopes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 1, 1, 3 };
            int k = 4;
            var result = solution(k, A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int k, int[] A)
        {
            var length = A.Length;
            var count = 0;
            var sum = 0;
            
            for (int i = 0; i < length; i++)
            {
                if (length > 1)
                {
                    sum += A[i];
                    if (sum >= k)
                    {
                        ++count;
                        sum = 0;
                    }
                }
                else
                {
                    if (A[i] >= k)
                        ++count;
                }
                        
            }
            return count;
        }
    }
}
