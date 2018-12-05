using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {1,3,4,5};
            var rez = solution(A);
            Console.WriteLine("Rezultat: {0}", rez);
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {           
            Array.Sort(A);
            var ret = A.Length + 1;

            for (var index = 0; index < A.Length; index++)
            {
                if (A[index] != index + 1)
                {
                    return index + 1;
                }
            }
            return ret;  // Empty array or element is missing from array
        }
    }
}
