using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ans = new int[] { 0, 1, 2 };
            Console.WriteLine(ans);

           /* foreach (var item in ans)
            {
                Console.WriteLine(item);
            }*/

            Console.ReadLine();
        }

        public static string OddOrEven(int[] array)
        {
            //enter code here

            return array.Sum() % 2 == 0 ? "even" : "odd";
        }
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


