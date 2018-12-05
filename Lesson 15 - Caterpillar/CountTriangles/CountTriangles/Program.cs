using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 10, 2, 5, 1, 8 , 12 };
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            Array.Sort(A);
            int ans = 0;
             int n = A.Length;
            for (int p = 0; p < n - 2; p++)
            {
                int r = 0; 
                for (int q = p + 1; q < n - 1; q++)
                {
                    while (r < n && A[p] + A[q] > A[r])
                    {
                        r++;
                    }
                    ans += r - q - 1;
                }
            }
            return ans;
        }
    }
}
