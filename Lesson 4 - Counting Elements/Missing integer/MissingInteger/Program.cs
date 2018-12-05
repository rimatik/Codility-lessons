using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {int.MinValue,int.MaxValue};
            int result = solution(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //public static int solution(int[] A)
        //{
        //    bool[] table = new bool[int.MaxValue];
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if(A[i] > 0)
        //        {
        //            if (table[A[i]] == false) table[A[i]] = true;
        //        }
        //    }

        //    int result = 1;
        //    for (int i = 1; i < table.Length; i++)
        //    {
        //        if (table[i] == false)
        //        {
        //            result = i;
        //            break;
        //        } 
        //    }

        //    return result;
        //}


        public static int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    if (!set.Contains(A[i]))
                    {
                        set.Add(A[i]);
                    }
                }
            }

            int j = 1;
            for (; j < set.Count + 1; j++)
            {
                if (!set.Contains(j))
                {
                    break;
                }
            }

            return j;
        }
    }
}
