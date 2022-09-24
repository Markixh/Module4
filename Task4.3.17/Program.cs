namespace Task4_3_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            for (int k = 0; k <= arr.GetUpperBound(0); k++)
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    for (int i = j; i <= arr.GetUpperBound(1) - 1; i++)
                        if (arr[k, i + 1] < arr[k, i])
                        {
                            var temp = arr[k, i];
                            arr[k, i] = arr[k, i + 1];
                            arr[k, i + 1] = temp;
                        }
            for (int j = 0; j <= arr.GetUpperBound(0); j++)
            {
                for (int i = 0; i <= arr.GetUpperBound(1); i++)
                    Console.Write(arr[j, i] + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}