using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] A = {1000000000};

            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {

            if (A.Length < 1 || A.Length > 100000)
                return 0;

            if (A.Any(x => x < 1) || A.Any(x => x > 1000000000))
                return 0;

            int[] orgArray = A;
            int orgArrayLength = A.Length;
            int[] descArray = A.Distinct().ToArray();
            int descArrayLength = A.Length;
            Array.Sort(descArray);

            if (orgArray[0] == 1 && orgArrayLength == 1) return 1;

            return descArray[descArrayLength - 1] == descArrayLength && descArrayLength == orgArrayLength ? 1 : 0;
            //Druga provjera je zbog toga da ako oba polja imaju istu dužinu treba se još provjeriti zadnji element
        }
    }
}
