using System.Xml.Linq;

namespace Task4_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Евгения", 27);
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            Console.Write("Введите ваше Имя: ");
            name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine($"Ваше имя {name}, а возраст {age}");
            Console.ReadKey();
        }
    }
}