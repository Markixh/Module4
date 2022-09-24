using System.Diagnostics.Metrics;

namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool IfPet, byte Age, string[] FavColors)[] User = new(string, string, string, int, bool, byte, string[])[3];
            for (int i = 0; i < User.Length; i++)
            {
                Console.WriteLine("Данные {0} пользователя", i + 1);
                Console.WriteLine("Введите имя");
                User[i].Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User[i].LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User[i].Login = Console.ReadLine();
                User[i].LoginLength = User[i].Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                switch (Console.ReadLine())
                {
                    case "Да":
                    case "да":
                    case "Yes":
                    case "yes":
                        User[i].IfPet = true;
                        break;
                    default:
                        User[i].IfPet = false;
                        break;
                }

                Console.WriteLine("Введите возраст пользователя");
                User[i].Age = Convert.ToByte(Console.ReadLine());

                User[i].FavColors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int j = 0; j < User[i].FavColors.Length; j++)
                {
                    User[i].FavColors[i] = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}