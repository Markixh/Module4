namespace Task4_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.Write("Введите имя вашего питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;
            Console.Write("Какой у вас питомец: ");
            Pet.Type = Console.ReadLine();
            Console.Write("Введите возраст вашего питомца: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"У вас {Pet.Type} {Pet.Name}, возраст {Pet.Age.ToString("0.0")}");
            Console.ReadKey();
        }
    }
}