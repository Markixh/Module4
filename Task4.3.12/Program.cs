namespace Task4_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int[] sortarr = new int[arr.Length];
            int min = 100000;
            int prev = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if ((arr[j] < min) && (arr[j] > prev))
                    {
                        min = arr[j];
                    }
                }
                sortarr[i] = min;
                prev = min;
                min = 100000;
            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write(sortarr[i]);
            Console.ReadKey();
        }
    }
}