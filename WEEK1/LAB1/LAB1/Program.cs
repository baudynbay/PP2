using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();

            foreach (string s in arr)
            {
                int sum = 0;
                for (int i = 2; i <= arr.Length; i++) {
                    if (int.Parse(s) % i == 0)
                        sum += 1;
                }
                if (sum == 1) {
                    Console.Write(s);
                    Console.Write(" ");
                } }


        }
    }
}
