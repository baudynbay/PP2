using System;
using System.Collections.Generic;
namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            List<string> number = new List<string>();


            foreach(string s in arr)
            {
                number.Add(s);
                number.Add(s);
            }

            foreach(string s in number)
            {
                Console.Write(s + ' ');
            }
        }
    }
}
