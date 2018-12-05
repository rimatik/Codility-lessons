using System;

namespace NumberSolitaire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, -2, 0, 9, -1, -2 };
            //int[] A = { 1, -2, 0};
            //int[] A = { 1, -2 };
            //int[] A = { 0, -4, -5, -2, -7, -9, -3, -10 };
            var result = solution(A);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static int solution(int[] A)
        {
            int[] r = new int[A.Length];

            r[0] = A[0];

            for (int i = 0; i < r.Length; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (i + j >= A.Length)
                    {
                        break;
                    }

                    int result = r[i] + A[i + j];

                    if (r[i + j] == 0 || r[i + j] < result)
                    {
                        r[i + j] = result;
                    }
                }
            }

            return r[A.Length - 1];
        }
    

    //public static int solution(int[] A)
    //    {
    //        var sum = 0;
    //        var length = A.Length;
    //        var counter = 0;
    //        if (length <= 3)
    //        {
    //            if(length == 2)
    //            {
    //                for (int i = 0; i < length; i++)
    //                {
    //                    sum += A[i];
    //                }
    //            }
    //            else
    //            {
    //                for (int i = 0; i < length; i++)
    //                {
    //                    if (A[1] > A[0])
    //                    {
    //                        sum += A[1] + A[0] + A[2];

    //                    }
    //                    else
    //                    {
    //                        sum += A[0] + A[2];
    //                    } 

    //                }
    //            }


    //            return sum;
    //        }
    //        else
    //        {
    //            var max = A[1];
    //            sum += A[0];
    //            var ic = 0;
    //            for (int i = 2; i < length - 2; i++)
    //            {
    //                ++counter;
    //                ic = i + counter;
    //                if(ic < length - 2) 
    //                { 
    //                    if (A[ic] > max)
    //                    {
    //                        max = A[ic];
    //                        sum += max;
    //                        counter = 0;
    //                    }                          
    //                }                                              
    //           }
    //        }

    //        return sum + A[length - 1];
    //    }
}
    }

