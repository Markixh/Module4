namespace Task4_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0; //Без присвоения значения не выполнял операцию
            double X = 0 , Y = 0;
            var C = A < B | X > Y;
            Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}