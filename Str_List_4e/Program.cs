using System;
using System.Collections.Generic;

namespace Str_List_4g
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>() { "Tom", "Bob", "Sam" , "Aaa", "12321","Але","ксандр"};
            for (int i = 0; i < people.Count; i++)
            {
                Console.Write(people[i] + " ");
            }

            RevList(people);

            Console.WriteLine("\nНовый список:");
            for (int i = 0; i < people.Count; i++)
            {
                Console.Write(people[i] + " ");
            }

            List<string> RevList(List<string> list)
            {
                list.RemoveAt(list.Count - 1);
                return list;
            }
        }
    }
}
