using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsDistinct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { -5,-3, -1, 0, 3, 6 };
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            var length = A.Length;
            HashSet<int> set = new HashSet<int>();
            var num = 0;
            for (int i = 0; i < length; i++)
            {
                num = A[i];
                if (num < 0)
                    num = (-1 * A[i]);
                if(!set.Contains(num))
                    set.Add(num);
            }

            return set.Count();

        }
    }
}
