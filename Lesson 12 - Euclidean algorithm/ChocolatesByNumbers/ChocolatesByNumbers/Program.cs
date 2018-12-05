using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolatesByNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = 10;
            var M = 4;
            var result = PrintNChocolatesInaCircle(N, M);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static int solution(int N, int M)
        {
            HashSet<int> set = new HashSet<int>();
            var next = 0;
            var count = 1;
            for(int i = 0; i < N - 1; i++)
            {
                if (i == 0)
                    set.Add(i);
                else
                {
                    next = (next + M) % N;
                    if (set.Contains(next))
                        break;
                   ++count;
                    set.Add(next); 
                }
            }
            return count;
        }
        public static int solution(int N, int M)
        {
            if (M == 1) return N;
            if (M == N) return 1;

            int a = N, b = M;
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return N / a;
        }

    }
}
