using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A =   {-1000,1000};
       
           var result = SolutionBestPerformance(A);
            Console.WriteLine("Smallest diff: {0}", result);
            Console.ReadLine();

        }
       

        public static int solution50PercentSolution(int[] A)
        {
            if ((A.Length < 2 || A.Length > 100000))
            {
                return 0;
            }

            int min = 0;
            for (int i = 1; i < A.Length; i++)
            {

                if (A[i] < -1000 || A[i] > 1000)
                {
                    return 0;
                }
                var listLeft = A.Take(i).ToList();
                var listRight = A.Skip(i).Take(A.Length - i).ToList();
                int diffSum = listLeft.Sum() - listRight.Sum();
                if (diffSum < 0)
                    diffSum *= (-1);

                if (i == 1)
                    min = diffSum;

                if (diffSum < min)
                    min = diffSum;
            }

            return min;
        }

        private static int SolutionBestPerformance(int[] A)
        {
            if ((A.Length < 2 || A.Length > 100000))
            {
                return 0;
            }

            int sum = A.Sum();
            var listLeft = 0;
            var listOfDiffs = new List<int>();
            foreach (var item in A)
            {
                if (item < -1000 || item > 1000)
                {
                    return 0;
                }

                listLeft += item;
                int diffSum = Math.Abs(Math.Abs(sum) - Math.Abs(listLeft) - Math.Abs(listLeft));

                
               listOfDiffs.Add(diffSum);
                             
            }

            return listOfDiffs.Min();
        }
    }
}
