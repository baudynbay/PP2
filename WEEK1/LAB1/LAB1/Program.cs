using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
                string[] arr = Console.ReadLine().Split();

            foreach(string s in arr)
            {
                if (int.Parse(s) % 2 == 0)
                    Console.Write(s);
                Console.Write(" ");
            }


        }
    }
}
