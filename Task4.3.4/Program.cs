﻿namespace Task4_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя");
            var name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам:");
            foreach (var ch in name)
                Console.Write($"{ch} ");
            Console.Write("Последняя буква вашего имени: {0}", name[name.Length - 1]);
            Console.ReadKey();
        }
    }
}