using System;
using System.Linq;

namespace DailyAlgorithms
{
    public  class Program
    {
        static void Main(string[] args)
        {
            var ans = Longest("aretheyhere", "yestheyarehere");
            Console.WriteLine(ans);

            Console.WriteLine("Hello World!");
        }


        public static string Longest(string s1, string s2)
        {
            // your code
            /*  var temp = s1.Concat(s2).ToArray();
              Array.Sort(temp);
              var result = "";
              for (int i = 0; i < temp.Length; i++)
              {
                  if (!result.Contains(temp[i]))
                  {
                      result += temp[i];
                  }
              }

              return result;*/
            return new string((s1 + s2).Distinct().OrderBy(x => x).ToArray());

        }

        // https://www.codewars.com/kata/5412509bd436bd33920011bc/train/csharp

        /* public static string Maskify(string cc)
         {
             var result = "";
             if (cc.Length <= 4)
             {
                 result = cc;
             }
             else
             {
              for (var i = 0; i < cc.Length; i++)
                 {
                     if(i <= cc.Length - 5)
                     {
                         result += "#";
                     } else
                     {
                         result += cc[i];
                     }
                 }

             }
             return result;
         }*/

        //https://www.codewars.com/kata/558fc85d8fd1938afb000014
        /*    public static int sumTwoSmallestNumbers(int[] numbers)
            {
                //Code here...
                int sum = 0;
                sum = numbers.OrderBy(x => x).Take(2).Sum();
                return sum;
            }*/

        // https://www.codewars.com/kata/55908aad6620c066bc00002a/train/csharp
        /*    public static bool XO(string input)
            {
                //Code it!
                int x = 0;
                int o = 0;

                char[] letters = input.ToLower().ToCharArray();
                foreach(char c in letters)
                {
                    if(c == 'x')
                    {
                        x++;
                    } else if(c == 'o')
                    {
                        o++;
                    }
                }

                return x == 0;

              //  return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == '0');
            }*/

    }


}
