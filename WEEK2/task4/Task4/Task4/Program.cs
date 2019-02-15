using System;
using System.IO;

namespace Task31
{
    class Program
    {

        static void Main(string[] args)
        {

            DirectoryInfo path = new DirectoryInfo("/Users/baudynbay/desktop/pp2");

            if (!(File.Exists("/Users/baudynbay/desktop/pp2/input.txt")))
            {
                FileStream text = File.Create("/Users/baudynbay/desktop/pp2/input.txt");
                text.Close();
            }

            if (!(Directory.Exists("/Users/baudynbay/desktop/pp2/papka"))){
                Directory.CreateDirectory("/Users/baudynbay/desktop/pp2/papka");
            }

            File.Copy("/Users/baudynbay/desktop/pp2/input.txt", "/Users/baudynbay/desktop/pp2/papka/input.txt",true);
            File.Delete("/Users/baudynbay/desktop/pp2/input.txt");

        }
    }
}