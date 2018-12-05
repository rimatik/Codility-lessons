using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 4,4,5,5,1 };
            int[] B = { 3,2,4,3,1 };
            var collection = solution(A, B);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static int[] solution(int[] A, int[] B)
        {
            var length = A.Length;
            var allFibonnacis = buildCache(A.Max(),B.Max());
            List<int> listOfLadderRungs = new List<int>();
            for (int i = 0; i < length; i++)
            {
                listOfLadderRungs.Add(allFibonnacis[A[i]] % (int)Math.Pow(2, B[i]));
            }
                return listOfLadderRungs.ToArray();
            }

        public static int[] buildCache(int n, int p)
        {
            int[] cache = new int[n + 1];
            int previous = 1;
            int current = 1;

            cache[0] = 1;
            cache[1] = 1;

            int index = 3;

            while (index <= n + 1)
            {
                int temp = current;
                current = (previous + current) % (int)Math.Pow(2, p);
                previous = temp;

                cache[index - 1] = current;

                index++;
            }

            return cache;
        }

    }
   
}
