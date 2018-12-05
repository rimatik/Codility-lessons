using System;
using System.Collections.Generic;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = "[()()[";
            var result = solution(S);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //public static int solution(string S)
        //{      
        //    var countCurlyLeftBracket = 0;
        //    var countCurlyRightBracket = 0;
        //    var countSquareLeftBracket = 0;
        //    var countSquareRightBracket = 0;
        //    var countLeftBracket = 0;
        //    var countRightBracket = 0;

        //    if (S.Length > 0)
        //    {
        //        if (S[0] == '{' && S[S.Length - 1] == '}' || S[0] == '(' && S[S.Length - 1] == ')' ||
        //            S[0] == '[' && S[S.Length - 1] == ']')
        //        {
        //            foreach (var t in S)
        //            {
        //                if (t == '{')
        //                    ++countCurlyLeftBracket;
        //                else if (t == '}')
        //                    ++countCurlyRightBracket;
        //                else if (t == '[')
        //                    ++countSquareLeftBracket;
        //                else if (t == ']')
        //                    ++countSquareRightBracket;
        //                else if (t == '(')
        //                    ++countLeftBracket;
        //                else if (t == ')')
        //                    ++countRightBracket;
        //            }
        //            if (countCurlyLeftBracket != countCurlyRightBracket
        //                    || countSquareLeftBracket != countSquareRightBracket
        //                    || countLeftBracket != countRightBracket)
        //                return 0;
        //            return 1;
        //        }
        //    }
        //    else if (S.Length == 0)
        //        return 1;
        //    return 0;
        //}

        //public static int solution(string S)
        //{
        //    var stack = new Stack<string>(); 
        //    foreach (var c in S)
        //    {
        //        if (c == '{' || c == '(' || c == '[')
        //            stack.Push(c.ToString());
        //        else if (c == '}' || c == ')' || c == ']')
        //        {
        //            var t = stack.Pop() + c;
        //            if (t != "{}" && t != "()" && t != "[]")
        //                return 0;
        //        }
        //        else
        //            return 0;
        //    }
        //    return stack.Count > 0 ? 0 : 1;
        //}

        public static int solution(string S)
        {

            // Return 1 if string size is 0 
            if (S.Length == 0) return 1;

            Stack<char> brackets = new Stack<char>();

            foreach (char c in S)
            {
                if (c == '[' || c == '{' || c == '(')
                {
                    brackets.Push(c);
                }
                else
                {
                    // return 0 if no opening brackets found and 
                    // first bracket is a closing bracket
                    if (brackets.Count == 0) return 0;

                    if (c == ')')
                    {
                        if (brackets.Peek() == '(') brackets.Pop();
                        else return 0;
                    }

                    if (c == '}')
                    {
                        if (brackets.Peek() == '{') brackets.Pop();
                        else return 0;
                    }

                    if (c == ']')
                    {
                        if (brackets.Peek() == '[') brackets.Pop();
                        else return 0;
                    }
                }
            }

            if (brackets.Count == 0) return 1;

            return 0;
        }
    }
}



