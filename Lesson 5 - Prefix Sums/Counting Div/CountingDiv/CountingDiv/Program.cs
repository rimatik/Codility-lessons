using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 6;
            int B = 12;
            int K = 2;
            var result = solution(A, B, K);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int A, int B, int K)
        {
            int offsetForLeftRange = 0;
            if (A%K == 0)
            {
                ++offsetForLeftRange;
            }
            return (B / K) - (A / K) + offsetForLeftRange;
        }
    }
}
