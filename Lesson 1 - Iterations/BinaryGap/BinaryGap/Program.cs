using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = 5;
            var result = solution(N);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        

        public static int solution(int N)
        {
            var binaryNumberStr = Convert.ToString(N, 2);
            var countOnes = 0;
            var countZeros = 0;
            var maxCountZeros = 0;
            char chr = new char();

            for (int i = 0; i < binaryNumberStr.Length; i++)
            {

                chr = binaryNumberStr[i];
                if (chr == '1')
                    ++countOnes;
                else
                    ++countZeros;

                if (countOnes == 2)
                {
                    if(countZeros > maxCountZeros)
                        maxCountZeros = countZeros;
                    countZeros = 0;
                    countOnes = 1;
                }   
                
            }

            return maxCountZeros;
        }
    }
}
