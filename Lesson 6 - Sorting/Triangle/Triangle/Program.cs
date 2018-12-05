using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64[] A = { 10, 2, 5, 1, 8 , 20 };
            //int[] A = { 10, 50, 2, 1 };
            //int[] A = { 10, 50, 2, 1 };
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(long[] A)
        {
            var length = A.Length;
            Array.Sort(A);
            for (var i = 0;i< length; i++)
            {
                if (i + 2 <= length-1)
                {
                    if (A[i] + A[i + 1] > A[i + 2])
                    {
                        return 1;
                    }
                    if (A[i] == A[i + 2] &&
                        A[i + 2] == A[i + 1] &&
                            A[i] == Int32.MaxValue)
                    {
                        return 1;
                    }
                }  
            }

            return 0;
        }
    }
}
