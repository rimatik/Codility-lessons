using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {0, 1, 0, 1, 1};
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            var list = A.ToList();
            var countOnes = A.Count(x => x == 1);
            var pairs = 0;

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i] == 0)
                {
                    pairs += countOnes;

                    if (pairs > 1000000000)
                        return -1;
                }
                else
                 {
                    countOnes -= 1;
                }
            }
            return pairs;
        }
    }
}
