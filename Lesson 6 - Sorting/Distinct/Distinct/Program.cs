using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 2 , 1, 1, 2, 3 , 1 };
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            return A.Distinct().Count();
        }

    }
}


//var result = new HashSet<int>(A);
//return result.Count();