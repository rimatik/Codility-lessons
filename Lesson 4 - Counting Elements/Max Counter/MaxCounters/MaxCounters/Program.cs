using System;
using System.Linq;

namespace MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            //int[] A = {3,4,4,6,1,4,4};
            int[] A = { 6, 6, 6, 6, 6};
            var result = solution(N,A);
            foreach(var item in result)
                Console.WriteLine(item);
            Console.ReadLine();
        }

       

        public static int[] solution(int N, int[] A)
        {
            int[] result = new int[N];
            int maximum = 0;
            int resetLimit = 0;

            for (int K = 0; K < A.Length; K++)
            {

                if (A[K] >= 1 && A[K] <= N)
                {
                    //ako je trenutni counter manji od reset limita povećaj ga za resetLimit + 1, 
                    //jer da se to ne napravi gubili bi se neke vrijednosti countera koji su manji od limita
                    //povećavaš ga za jedan jer to gledaš kao operaciju increse(X) gdje se counter povećava za 1
                    if (result[A[K] - 1] < resetLimit)
                    {
                        result[A[K] - 1] = resetLimit + 1;
                    }
                    else
                    {
                        result[A[K] - 1]++;
                    }

                    if (result[A[K] - 1] > maximum)
                    {
                        maximum = result[A[K] - 1];
                    }
                }
                else
                {
                    resetLimit = maximum;
                }
            }

            for (int i = 0; i < result.Length; i++)
                result[i] = Math.Max(resetLimit, result[i]);

            return result;
        }

    }
}
