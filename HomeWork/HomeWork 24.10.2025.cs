public class Program
{
    public static void Main(string[] args)
    {
        Print("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Print("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        Print("Введите символ операции: ");
        char char1 = Convert.ToChar(Console.ReadLine());

        if (char1 == '*')
        {
            Multiplication(number1, number2);
        }
        else if (char1 == '+')
        {
            Addition(number1, number2);
        }
        else if (char1 == '-')
        {
            Subtraction(number1, number2);
        }
        else if (char1 == '/')
        {
            Division(number1, number2);
        }
        Console.ReadLine();
    }
    public static void Print(string s)
    {
        Console.WriteLine(s);
    }
    public static void Multiplication(double number, double number2)
    {
        double opi = number * number2;
        Console.WriteLine($"Результат: {opi} ");
    }
    public static void Addition(double number, double number2)
    {
        double opi = number + number2;
        Console.WriteLine($"Результат: {opi} ");
    }
    public static void Subtraction(double number, double number2)
    {
        double opi = number - number2;
        Console.WriteLine($"Результат: {opi} ");
    }
    public static void Division(double number, double number2)
    {
        double opi = number / number2;
        Console.WriteLine($"Результат: {opi} ");
    }



}