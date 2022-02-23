using System;
using System.Collections.Generic;

namespace Str_List_4g
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>() { "Tom", "Bob", "Sam"};
            Console.WriteLine("Начальный список:");
            for (int i = 0; i < people.Count; i++)
            {
                Console.Write(people[i] + " ");
            }
            Console.WriteLine("Сколько элементов добавить в список?");
            int n = 0;

            while(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Введена неверная форма числа! Попробуйте снова.");
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write($"Введите новый элемент списка №{i+1}:");
                people.Add(Console.ReadLine());
                Console.WriteLine("");
            }

            Console.WriteLine("Новый список до изменений:");
            for (int i = 0; i < people.Count; i++)
            {
                Console.Write(people[i] + " ");
            }
            Console.WriteLine("\nУдалить последний элемент или закончить выполнение программы?\n1.Удалить\n0.Закончить");
            while (Console.ReadLine() == "1")
            {
                if(people.Count == 0)
                {
                    Console.WriteLine("В списке закончились элементы.");
                    break;
                }
                
                RevList(people);

                Console.WriteLine("\nНовый список:");
                for (int i = 0; i < people.Count; i++)
                {
                    Console.Write(people[i] + " ");
                }
                Console.WriteLine("\nУдалить последний элемент или закончить выполнение программы?\n1.Удалить\n0.Закончить");
            }

            Console.WriteLine("Конец работы программы");

            List<string> RevList(List<string> list)
            {
                list.RemoveAt(list.Count - 1);
                return list;
            }
        }
    }
}
