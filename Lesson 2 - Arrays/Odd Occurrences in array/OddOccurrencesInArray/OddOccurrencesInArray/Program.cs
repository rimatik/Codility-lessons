using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    //Pronađi neupareni element polja i vrati ga, array može imati N [1...1,000,000], 
    // svaki element je u range-u od [1...1,000,000], svi osim jednog elementa dolaze po dva puta

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {9,4,9,4,5,1,5,2,2};

            var result = solution(A);
            Console.WriteLine("Traženi broj je: {0}",result);
            Console.Read();
        }

        static int  solution(int[] A)
        {
            if (A.Length <= 1 && A.Length >= 1000000)
                return 0;
            if (A.All(x => x <= 1 && x >= 1000000))
                return 0;

            int value = 0;
            for (int i = 0; i < A.Length; i++)
            {
                value = value ^ A[i];
            }
                
            return value;
        }

    }
}
