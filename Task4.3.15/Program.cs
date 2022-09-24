namespace Task4_3_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] {4, -4, 2, -4, -2, 0, 5, 6, -8};
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
                if(arr[i] > 0)
                    count++;
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}