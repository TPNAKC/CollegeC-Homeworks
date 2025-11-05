public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Исходный массив:");
        int[] array = {10,20,30,40,50};
        for (int i = 0;i < 5; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine("\nПеревернутый массив:");
        for(int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write($"{array[i]} ");
        }

    }
}