using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        Console.WriteLine(secretNumber);
        Console.WriteLine("Я загадал число от 1 до 100. У вас 7 попыток:");
        Console.WriteLine("Попытка №1:");
        int userGuess = Convert.ToInt32(Console.ReadLine());
        while (userGuess != secretNumber)
        {
            for (int i = 2; i < 7; i++)
            {
                userGuess = userGuess;
                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Поздравляю! Вы угадали число.");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Ваше число больше загаданного числа. Попробуйте ещё раз.");
                    Console.WriteLine($"Попытка №{i}. Ваша догадка:{userGuess}");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Ваше число меньше заданного числа. Попробуйте ещё раз.");
                    Console.WriteLine($"Попытка №{i}. Ваша догадка:{userGuess}");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                break;
            }

            break;
        }
        if (userGuess == secretNumber)
        {
            Console.WriteLine("Поздравляю! Вы угадали число.");
            Console.WriteLine("Вы хотите сыграть ещё раз? (Да/Нет)");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("У вас закочились попытки.");
            Console.WriteLine("Вы хотите сыграть ещё раз? (Да/Нет)");
            Console.ReadLine();
        }
    }
}
