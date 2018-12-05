using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNonDivisible
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 1 , 2 , 2, 1  };
            var result = solution(A);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
        public static int[] solution(int[] A)
        {
            var length = A.Length;
            var count = 0;
            Hashtable table = new Hashtable();
            List<int> list = new List<int>();
            for (int i = 0; i < length; i++)
            {
                if (table.ContainsKey(A[i]))
                {
                    list.Add((int)table[A[i]]);
                    continue;
                }
                for (int j = 0; j < length; j++)
                {
                    if (A[i] % A[j] > 0)
                        ++count;
                }
                list.Add(count);
                table.Add(A[i], count);
                count = 0;
            }
            return list.ToArray();
        }
    }
}
