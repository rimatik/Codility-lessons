using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrSymmetryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = "abc";
            var result = solution(S);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(string S)
        {
            var length = S.Length;
            var count = 0;
            if(length > 1)
            {
                for (int i = 0; i <= length / 2; i++)
                {
                    var fromLast = length - 1 - i;
                    var check = length - count * 2;
                    if (S[i] == S[fromLast] && check != 1)
                    {
                        ++count;
                    }
                    else if (check == 1)
                        return i;
                }
                return -1;          
            }
            else if(length == 1)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
