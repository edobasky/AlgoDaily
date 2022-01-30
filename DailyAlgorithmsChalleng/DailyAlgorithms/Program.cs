using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ans = GetMiddle("test");
            Console.WriteLine(ans);

           /* foreach (var item in ans)
            {
                Console.WriteLine(item);
            }*/

            Console.ReadLine();
        }



        public static string GetMiddle(string s)
        {
            //Code goes here!
            var ans = "";
            var temp = s.ToCharArray();
            var l = temp.Length;

            if (l % 2 == 0)
            {
                ans = (temp[(l / 2) - 1]).ToString() + (temp[l / 2]).ToString();
            }
            else
            {
                ans = (temp[(l - 1) / 2]).ToString();
            }
            return ans;
        }
        /*        public static IEnumerable<string> OpenOrSenior(int[][] data)
                {
                    //your code here
                     List<string> ans = new List<string>();
                    for (int i = 0; i < data.Length; i++)
                    {

                             if (data[i][0] >= 55 && data[i][1] > 7)
                            {
                                ans.Add("Senior");
                            }else
                            {
                                ans.Add("Open");
                            }

                    }
                    return ans;
                }
        */
    }
}


