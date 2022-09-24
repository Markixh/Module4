namespace Task4_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eman = "";
            Console.WriteLine("Введите свое имя");
            var name = Console.ReadLine();
            Console.WriteLine("Ваше имя в обратном порядке:");
            foreach (var ch in name)
                eman = ch + eman;
            Console.WriteLine(eman);
            Console.ReadKey();
        }
    }
}