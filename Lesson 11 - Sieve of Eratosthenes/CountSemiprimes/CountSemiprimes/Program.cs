using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSemiprimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int N = 26;
            //int[] P = {1,4,16};
            //int[] Q = {26,10,20};
            int N = 50000;
            int[] P = {1};
            int[] Q = {50000};
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result = solution(N, P, Q);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalSeconds);
            Console.ReadLine();
        }
     

        public static int[] solution(int N, int[] P, int[] Q)
        {
            int length = P.Length;
            List<int> list = new List<int>();

            HashSet<int> listOfSemiprimes = new HashSet<int>();
            listOfSemiprimes = ListOfSemiprimes(N);

            var count = 0;
            for (int i = 0; i < length; i++)
            {
                int p = P[i];
                int q = Q[i];
                if(N >= q && q >= p)
                {
                    if (p < 4 && q >= 4)
                        p = 4;
                    for (int j = p; j <= q; j++)
                    {
                        if (listOfSemiprimes.Contains(j))
                            ++count;                             
                    }
                    list.Add(count);
                    count = 0;
                }
            }
            return list.ToArray();
        }


        public static HashSet<int> ListOfSemiprimes(int n)
        {
            HashSet<int> list = new HashSet<int>();
            int p, check,result, f = 0;
            var k = 0;
            for(int i = 4; i <= n; i++)
            {
                check = i;
                result = i;
                for (p = 2; f < 2 && p * p <= check; p++)
                {
                    while (0 == check % p)
                    {
                        check /= p;
                        f++;
                    }
                }

                k = 0;
                if (check > 1)
                    k = 1;
                if ((f + k) == 2)
                    list.Add(result);
                p = 0;
                f = 0;            
            }           
            return list;
        }

  
    }
}
