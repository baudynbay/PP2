using System;
using System.Collections.Generic;
using System.IO;
namespace TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader a = new StreamReader("a.txt");
            string n = a.ReadToEnd();
            char[] text = n.ToCharArray();
            Array.Reverse(text);
            string newText = new string(text);

            if (newText == n)
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }
            a.Close();
        }
    }
}
