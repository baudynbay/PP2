using System;

namespace task2
{ 

class animal
{
    public string name;
    public int age;
   

        public animal(string name, int age)
        {
            this.name = name;
            this.age = age;
         }

        public void show()
        {
            Console.WriteLine("Name: "+name + " Age: " +age);
        }
    }


class Program
    {
        static void Main(string[] args)
        {
            animal daniyar = new animal("daniyar",3);
            daniyar.show();
        }
    }
}
