using System;
using System.IO;

namespace task2
{
    class Program
    {
        static bool Check (int t)
        {
            int sum = 0;
            if (t == 1) return true;
            if (t == 2) return false;
            for (int i=2; i<t; i++)
            {
                if (t % i == 0)
                    sum++;
            }
            if (sum > 0)
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            StreamReader a = new StreamReader("a.txt");
            StreamWriter ba = new StreamWriter("outpur.txt");
            string n = a.ReadLine();
            string[] number = n.Split();
             
            foreach (string s in number)
            {
                if (Check(int.Parse(s))== false)
                {
                    ba.Write(s+" ");
                }
            }
            a.Close();
            ba.Close();
        }

    }
}
