namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool IfPet, byte Age, string[] FavColors) User;
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию"); 
            User.LastName = Console.ReadLine();
            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
        }
    }
}