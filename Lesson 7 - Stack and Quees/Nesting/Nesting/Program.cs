using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "( ) ) ( ( )";
            var result = solution(S);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(string S)
        {
            var countLeftParentes = 0;
            var countRightParentes = 0; 
            if (S.StartsWith("(") && S.EndsWith(")"))
            {
                for(int i = 0;i<S.Length; i++)
                {
                    if (S[i] == '(')
                    {
                        ++countLeftParentes;
                    }
                    if (S[i] == ')')
                    {
                        ++countRightParentes;
                    }
                }
                if (countLeftParentes == countRightParentes)
                    return 1;
            }
            else if (S.Length == 0)
            {
                return 1;
            }          
            return 0;
        }
    }
}
