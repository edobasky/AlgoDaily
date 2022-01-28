using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ans = digPow(89, 1);
            Console.WriteLine(ans);

            /* foreach(var item in ans)
             {
                 Console.WriteLine(item);
             }*/

            Console.ReadLine();
        }


        public static long digPow(int n, int p)
        {
            // your code
            var temp = new string(n);
            var total = 0;
            for(int i = 0; i < temp.Length; i++)
            {
               total += (int)Math.Pow(temp[i], p);
                p++;
            }
            if (total == (n * p))
            {
                return total;
            }
            return -1;
        }

        /*  public static string HighAndLow(string numbers)
          {
              // Code here or
              *//* var c = numbers.Split(" ");
               List<int> temp = new List<int>();
               for(int i = 0; i < c.Length; i++)
               {
                   temp.Add(int.Parse(c[i]));
               }
               var ans = temp.OrderBy(x => x);
               return $"{ans.Max()} {ans.Min()}";*//*
     //********************************************************
              *//*var c = numbers.Split(" ").Select(Int32.Parse).ToArray();
              return $"{c.Max()} {c.Min()}`";*//*
          }*/

        /*  public static string PrinterError(String s)
          {
              // your code
              var num = "";

              num = string.Concat(s.Where(letter => !"a,b,c,d,e,f,g,h,i,j,k,l,m".Contains(letter)));
              return $"{num.Length} / {s.Length}";
          }*/



        /* public static string AddBinary(int a, int b)
          {
              // your code ...
              return Convert.ToString((a + b), 2);
          }*/

        /*public static string Disemvowel(string str)
        {
            return string.Concat(str.Where(letter => !"aeiouAEIOU".Contains(letter)));
        }*/

        /* public static int[] GetEvenNumbers(int[] numbers)
         {
             // filter out the odd numbers

             IEnumerable<int> ans = numbers.Where(x => x % 2 == 0);
             return ans.ToArray();
         }*/

        /* public static long rowSumOddNumbers(long n)
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
         }*/

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


