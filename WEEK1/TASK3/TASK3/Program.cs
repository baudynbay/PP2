using System;
using System.Collections.Generic;
namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //читаем сколько чисел есть
            string[] arr = Console.ReadLine().Split(); // читаем строку разделяя их по пробелам
            List<string> number = new List<string>(); // создаем динамический массив


            foreach (string s in arr) //для каждого элемента
            {
                number.Add(s); //добавляем с массива
                number.Add(s); // еще раз добавляем
            }

            foreach (string s in number)
            {
                Console.Write(s + ' '); //вывод
            }
        }
    }
}