using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrogJmp
{
    class Program
    {

        //If y - x is divisible by d, then it takes(y - x) / d jumps
        //If y - x is not divisible by d, then it takes(y - x) / d + 1 jumps
        static void Main(string[] args)
        {
            var result = solution(10, 85, 30);
            Console.WriteLine("Rezultat: {0}", result);
            Console.ReadLine();
        }

        private static int solution(int X, int Y, int D)
        {
            if (X < 1 || X > 1000000000)
                return 0;

            if (Y < 1 || Y > 1000000000)
                return 0;

            if (D < 1 || D > 1000000000)
                return 0;

            if (X >= Y)
                return 0;

            if (D >= Y)
                return 1;

            int distance = Y - X;

            return (distance % D == 0) ? distance / D : (distance + D) / D;

        }

    }
}




    
