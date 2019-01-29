using System;

namespace task4
{
    class Program

    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
                for (int  j = 1 ; j<= n; j++)
                {
                    for (int i =1; i<=j; i++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
            

                                        
        }
    }
}
