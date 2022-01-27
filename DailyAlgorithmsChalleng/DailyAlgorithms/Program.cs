using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ans = rowSumOddNumbers(2);
            Console.WriteLine(ans);

            Console.ReadLine();
        }

        public static long rowSumOddNumbers(long n)
        {
            var start = 0;
            for (int i = 0; i < n; i++)
            {
                start += i;
            }
            start *= 2;
            var ans = start + 1;
            for (int k = 0; k < n; k++)
            {
                ans += 2;
            }
            return ans;
        }

        /* public static string FirstReverse(string str)
         {

             // code goes here  
             var ans = "";
             for (int i = str.Length - 1; i >= 0; i--)
             {
                 ans += str[i];
             }
             return ans;

         }*/

        /*   // https://www.codewars.com/kata/56269eb78ad2e4ced1000013/train/csharp
           public static long FindNextSquare(long num)
           {
               // your code here
               var  ans = Math.Sqrt(num);
               if (ans - Convert.ToInt32(ans) != 0)
               {
                   return -1;
               }
               return Convert.ToInt64(Math.Pow((ans + 1), 2));
           }*/

        // https://www.codewars.com/kata/55b42574ff091733d900002f/train/csharp
        /*
                public static IEnumerable<string> FriendOrFoe(string[] names)
                {
                    // Good luck!
                    var ans = names.Where(x => x.Length == 4).Select(x => x).ToList();
                    return ans;

                }*/
    }

}
