using System;
using System.Collections.Generic;

namespace DecaAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = PrimeString("abcabcabc");
            Console.WriteLine(ans);
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

            for(var i = 0; i < s.Length; i++)
            {
                if (s[i] == wrd[wrd.Count - 1])
                {
                    tempHold +=s[i];
                    tempAns.Add(tempHold);
                    tempHold = "";
                    continue;
                } else if (i == (s.Length - 1))
                {
                    tempHold += s[i];
                    tempAns.Add(tempHold);
                    tempHold = "";
                    continue;
                }
                tempHold += s[i];


            }

           
            // compare start and end of seperated word to check for repeated initial and end of compare string
            foreach(var item in tempAns)
             {
                if(!item.StartsWith(wrd[0]) || !item.EndsWith(wrd[wrd.Count-1]))
                {
                    return true;
                }
            }
            return false;
          
        }
    }
}
