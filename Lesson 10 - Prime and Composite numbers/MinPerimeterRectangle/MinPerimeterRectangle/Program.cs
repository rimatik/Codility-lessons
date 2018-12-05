using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MinPerimeterRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = 30;
            var result = solution(N);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //public static int solution(int N)
        //{
        //    var minPerimeter = 0;
        //    for (var i = 1; i <= N; i++)
        //    {
        //        if (i == 1)
        //        {
        //            minPerimeter = 2*(i + N);
        //        }                   
        //        if (N%i == 0)
        //        {
        //            var divisor = N/i;
        //           var perimeter = 2*(i + (divisor));
        //            if (minPerimeter > perimeter)
        //            {
        //                minPerimeter = perimeter;
        //                if(divisor == 2)
        //                    break;
        //            }
                        
        //        }
        //    }
        //    return minPerimeter;
        //}

        public static int solution(int N)
        {
            var minPer = int.MaxValue;

            for (var i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    minPer = Math.Min(minPer, 2 * (N / i + i));
                }
            }

            return minPer;
        }
    }
}
