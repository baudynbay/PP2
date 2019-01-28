using System;
using System.Collections.Generic;
namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();

            foreach (string s in arr)
            {
                int sum = 0;

                for (int i = 2; i <= arr.Length; i++) {
                    if (int.Parse(s) % i == 0)
                    {
                      
                        sum += 1;
                    }
                }
                if (sum == 1) {
                    list.Add(s);
                } }

            Console.WriteLine(list.Count);
            foreach(string s in list)
            {
                Console.Write(s + " ");
            }
        }
    }
}
