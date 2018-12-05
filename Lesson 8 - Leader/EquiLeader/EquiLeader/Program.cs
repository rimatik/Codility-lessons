using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiLeader
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 1, 1, 2, 1 };
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            var len = A.Length;
            var equi_leaders = 0;

            var leader = A[0];
            var ctr = 1;

            for (var i = 1; i < A.Length; i++)
            {
                if (A[i] == leader) ctr++;
                else ctr--;
                if (ctr == 0)
                {
                    ctr = 1;
                    leader = A[i];
                }
            }

            var total = A.Count(i => i == leader);

            if (total <= (len / 2)) return 0; 

            var ldrCount = 0;
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] == leader) ldrCount++;
                var leadersInRightPart = (total - ldrCount);
                if (ldrCount > (i + 1) / 2 && leadersInRightPart > (len - i - 1) / 2)
                {
                    equi_leaders++;
                }
            }

            return equi_leaders;
        }
    }
}


