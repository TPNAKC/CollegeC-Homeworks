using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        Print("Введите число:");
        int factorial = Convert.ToInt32(Console.ReadLine());
        int number = Fact(factorial);
        if (number >= 0)
        {
            Console.WriteLine(number);
        }
        else
        {
            Print("Ошибка");
        }
    }
    public static int Fact(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    public static void Print(string n)
    {
        Console.WriteLine(n);
    }
}