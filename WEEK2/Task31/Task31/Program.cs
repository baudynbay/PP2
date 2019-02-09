using System;
using System.IO;

namespace Task31
{
    class Program
    {
        public static void ReadFiles(DirectoryInfo files, int level)
        {
            foreach (FileInfo t in files.GetFiles())
            {
                Space(level);
                Console.WriteLine(t.Name);
            }

            foreach(DirectoryInfo r in files.GetDirectories())
            {
                Space(level);
                Console.WriteLine(r.Name);
                ReadFiles(r, level + 1);
            }
        }

        public static void Space(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("     ");
        }
        static void Main(string[] args)
        {
            DirectoryInfo files = new DirectoryInfo("/users/baudynbay/desktop/pp2");
            ReadFiles(files, 0);
        }
    }
}
