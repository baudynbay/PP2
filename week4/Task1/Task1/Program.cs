using System;
using System.IO;


namespace Task1
{
    class Program
    {
        [Serializable]
        public class tutorial
        {
            public int ID;
            public string Name;

            public tutorial(int ID, string name)
            {
                this.ID = ID;
                this.Name = name;
            }
        }
        static void Main(string[] args)
        {
            tutorial obj = new tutorial(1234, "Serik");
            
        }
    }
}
