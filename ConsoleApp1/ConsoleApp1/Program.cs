using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ans = FindProcesses("field", "bread", new List<string> { "gather:field:wheat", "mill:wheat:flour", "bake:flour:bread" });
            Console.WriteLine("Hello World!");
        }

        public static List<string> FindProcesses(string start_item, string end_item, List<string> tasks)
        {
            if (start_item.Contains(end_item)) {
                return new List<string>() { };
            }
            string[] res = new string[3];
            foreach (var task in tasks)
            {
               if (task.Contains(start_item))
                {
                    res[0] = task;
                } else if (task.Contains(end_item))
                {
                    res[2] = task;
                } else
                {
                    res[1] = task;
                }
            }

            int num = 0;

            foreach (var task in res)
            {
                
                if(!task.Contains(start_item) ||!task.Contains(end_item))
                {
                    num += 1;
                }
            }

            if (num == 3) return new List<string>() { };

            List<string> ans = new List<string>();
            var tt = new List<string>();
            foreach (var item in res)
            {
                  item.Split(':');
            }
          
            return new List<string>();
        }
    }
}
