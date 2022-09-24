using System.Xml.Linq;

namespace Task4_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, byte age) anketa;
            Console.Write("Введите ваше Имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            anketa.age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine($"Ваше имя {anketa.name}, а возраст {anketa.age}");
            Console.ReadKey();
        }
    }
}