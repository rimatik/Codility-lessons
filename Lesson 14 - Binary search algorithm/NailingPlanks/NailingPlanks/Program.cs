using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailingPlanks
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 1 };
            //int[] B = { 2 };
            //int[] C = { 2 };
            //int[] A = { 1, 4, 5, 8 };
            //int[] B = { 4, 5, 9, 10 };
            //int[] C = { 4, 6, 7, 10, 2 };
            //int[] A = { 1, 4 };
            //int[] B = { 2, 5 };
            //int[] C = { 1, 2 };
            int[] A = { 2, 1, 2 };
            int[] B = { 2, 3, 3 };
            int[] C = { 1, 2, 2, 2 };
            int result = solution(A, B, C);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public class Ladder
        {
            public int start;
            public int end;

            public Ladder(int start, int end)
            {
                this.start = start;
                this.end = end;
            }
        }

        public static int solution(int[] A, int[] B, int[] C)
        {
            int countLadder = A.Length;
            int result = -1;
            Queue<Ladder> q = new Queue<Ladder>();
            int nails = 0;
            for (int i = 0; i < A.Length; i++)
            {
                q.Enqueue(new Ladder(A[i], B[i]));
            }
            Ladder ladder;
            int j = 0;
            for (int i = 0; i < C.Length; i++)
            {
                j = i;
                while (j < A.Length)
                {
                    if (q.Count > 0)
                    {
                        ladder = q.Dequeue();
                        int c = C[i];
                        if (c < ladder.start || c > ladder.end)
                        {
                            q.Enqueue(ladder);
                        }
                    }
                    if (q.Count == 0) break;
                    j++;
                }
                nails++;
                if (q.Count == 0)
                {
                    result = nails;
                    break;
                }
            }
            return result;
        }
    }
}
