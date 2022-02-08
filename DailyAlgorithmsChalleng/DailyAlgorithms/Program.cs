using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ans = PrimeString("abcabcabc");
            Console.WriteLine(ans);

            /* foreach (var item in ans)
             {
              *//*   Console.WriteLine(item);
             }*/

            Console.ReadLine();
        }

        public static bool PrimeString(string s)
        {
            var tempHold = "";

            // seperate the first set of repeated letters abc from abcabcabc... as compare strings
            List<char> wrd = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!wrd.Contains(s[i]))
                {
                    wrd.Add(s[i]);
                }
            };


            // loop through main word to separate repeated sets of charracters into a list as strings
            List<string> tempAns = new List<string>();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == wrd[wrd.Count - 1])
                {
                    tempHold += s[i];
                    tempAns.Add(tempHold);
                    tempHold = "";
                    continue;
                }
                else if (i == (s.Length - 1))
                {
                    tempHold += s[i];
                    tempAns.Add(tempHold);
                    tempHold = "";
                    continue;
                }
                tempHold += s[i];


            }


            // compare start and end of seperated word to check for repeated initial and end of compare string
            foreach (var item in tempAns)
            {
                if (!item.StartsWith(wrd[0]) || !item.EndsWith(wrd[wrd.Count - 1]))
                {
                    return true;
                }
            }
            return false;

        }

        /*  public static string ReverseWords(string str)
          {
              //Write your code here
              return string.Join(" ", str.Split(' ').Select(X => new string(X.Reverse().ToArray())));
          }*/

        /*  public static string OddOrEven(int[] array)
          {
              //enter code here

              return array.Sum() % 2 == 0 ? "even" : "odd";
          }*/
        /*
                public static int Number(List<int[]> peopleListInOut)
                {
                    // Happy Coding
                    *//* int totalInBus = 0;
                     int totalOutOfBus = 0;
                     for (int i = 0; i < peopleListInOut.Count; i++)
                     {

                         totalInBus += peopleListInOut[i][0];
                         totalOutOfBus = peopleListInOut[i][1];
                     }
                     return totalInBus - totalOutOfBus;*//*

                    return peopleListInOut.Sum(x => x[0] - x[1]);
                }*/

        /* public static bool Solution(string str, string ending)
         {
             // TODO: complete
             return str.EndsWith(ending);


         }*/

        /* public static int binaryArrayToNumber(int[] BinaryArray)
         {
             //Code here
             *//*var temp = "";

             foreach(var item in BinaryArray)
             {
                 temp += item;
             }

             return Convert.ToInt32(temp, 2);*//*
             return Convert.ToInt32(string.Join("", BinaryArray),2);

         }*/
    }
}


