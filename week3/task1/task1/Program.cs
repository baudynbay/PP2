using System;
using System.IO;

namespace Ex1
{
    class FarManager
    {
        public int cursor;
        public string path;
        public int sz;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;
        public int sumDirectory;
        public int sumFiles;

        public FarManager()
        {
            cursor = 0;
        }

        public FarManager(string path)
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            sz = directory.GetFileSystemInfos().Length;
            ok = true;
        }

        public void Color(FileSystemInfo fs, int index)
        {
            if (cursor == index)
            {
                //Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
              //  Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else
            {
              //  Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public void Show()
        {
            sumFiles = 0;
            sumDirectory = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }
                if (fs[i].GetType()== typeof(DirectoryInfo))
                {
                    sumDirectory++;
                }
                if (fs[i].GetType() == typeof(FileInfo))
                {
                    sumFiles++;
                }
                Color(fs[i], k);
                Console.WriteLine(k+"."+fs[i].Name);
                k++;

            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The amount of directory is " + sumDirectory);
            Console.WriteLine("The amount of files is " + sumFiles);
        }
        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }

        public void CalcSz()
        {
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            sz = fs.Length;
            if (ok == false)
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')
                        sz--;
        }


        public void Start()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape)
            {
                CalcSz();
                Show();
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();
                if (consoleKey.Key == ConsoleKey.RightArrow)
                {
                    ok = false;
                    cursor = 0;
                }
                if (consoleKey.Key == ConsoleKey.LeftArrow)
                {
                    cursor = 0;
                    ok = true;
                }
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = currentFs.FullName;
                    }
                    if (currentFs.GetType()== typeof(FileInfo))
                    {
                        StreamReader read = new StreamReader(currentFs.FullName);
                        string ret = read.ReadToEnd();
                        Console.WriteLine(ret);
                        Console.ReadKey();
                        read.Close();
                    }
                }
                if (consoleKey.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    path = directory.Parent.FullName;
                }
                if (consoleKey.Key == ConsoleKey.D)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        DirectoryInfo red = new DirectoryInfo(currentFs.FullName);
                        red.Delete(true);

                    }
                    if (currentFs.GetType() == typeof(FileInfo))
                    {
                        currentFs.Delete();
                    }
                }


                if (consoleKey.Key == ConsoleKey.R)
                { 
                if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        Console.WriteLine("Please enter a new name for this file:");
                        string newFilename = Console.ReadLine();
                        if (newFilename != String.Empty)
                        {
                            DirectoryInfo fi = new DirectoryInfo(currentFs.FullName);
                            fi.MoveTo(fi.Parent.FullName + "/" + newFilename);

                        }
                    }
                    if (currentFs.GetType() == typeof(FileInfo))
                    {
                        Console.WriteLine("Please enter a new name for this file:");
                        string newFilename = Console.ReadLine();
                        if (newFilename != String.Empty)
                        {

                           FileInfo fi = new FileInfo(currentFs.FullName);
                            fi.MoveTo(fi.Directory.FullName + "/" + newFilename);
                        }
                    }
                }


            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                string path = "/Users/baudynbay/desktop/pp2";
                FarManager farManager = new FarManager(path);
                farManager.Start();
            }
        }
    }
}