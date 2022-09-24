using System.Diagnostics.Metrics;

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
            User.LoginLength = User.Login.Length;
            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            switch (Console.ReadLine())
            {
                case "Да":
                case "да":
                case "Yes":
                case "yes":
                    User.IfPet = true;
                    break;
                default:
                    User.IfPet = false;
                    break;
            }            
        }
    }
}