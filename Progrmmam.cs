﻿using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value Tuple");

            ValueTuple<int, string, string> person1 = (1, "Jaan", "Tallinn");
            Console.WriteLine(person1.Item1);
            Console.WriteLine(person1.Item2);
            Console.WriteLine(person1.Item3);

            Console.WriteLine("--------------------------------");
            (int, string, string) person2 = (1, "James", "Bond");
            Console.WriteLine(person2.Item1);
            Console.WriteLine(person2.Item2);
            Console.WriteLine(person2.Item3);

            Console.WriteLine("------------------------------------");
            (int Id, string firstName, string lastName) person3 = (1, "Bill", "Gates");
            Console.WriteLine(person3.firstName);
            Console.WriteLine(person3.Id);
            Console.WriteLine(person3.lastName);

            Console.WriteLine("------------------------------------");
            ValueTuple((1, "Bill", "Värav"));
        }

        static void ValueTuple((int, string, string) person)
        {
            Console.WriteLine("{0}, {1}, {2}", person.Item1, person.Item2, person.Item3);

        }
    }
}
