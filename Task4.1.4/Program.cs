namespace Task4_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = "", B = ""; //Без присвоения значения не выполнял операцию
            var C = A != B;
            Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}