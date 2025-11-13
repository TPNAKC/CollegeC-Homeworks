using System.Collections.Generic;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("Слово");
        list.Add("Печать");
        list.Add("Выпечка");

        Print("Добро пожаловать в List.");
        Console.ReadLine();
        Print("Что вы хотите сделать?");
        Print("1. Добавить новую задачу в список.");
        Print("2. Посмотреть все добавленные задачи.");
        Print("3. Удалить задачу по её номеру.");
        Print("4. Выйти из программы.");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Print("Напишите что вы хотите добавить:");
                string word = Convert.ToString(Console.ReadLine());
                list.Insert(3, word);
                Print("Успешно сохраненно.");
                Console.ReadLine();
                break;
            case "2":
                Print("Все добавленные задачи:");
                for (int i = 0; i < list.Count; i++)
                {
                    Print($"{i + 1}. {list[i]}");
                }
                Console.ReadLine();
                break;
            case "3":
                for (int i = 0; i < list.Count; i++)
                {
                    Print($"{i + 1}. {list[i]}");
                }
                Print("Какое номер вы хотите удалить?");
                string choice2 = Convert.ToString(Console.ReadLine());
                bool wasRemoved = list.Remove(list[0]);
                Print("Успешно сохраненно.");
                Console.ReadLine();
                break;
            case "4":
                Print("Увидимся.");
                break;

        }
    }
    public static string Print(string str)
    {
        Console.WriteLine(str);
        return str;
    }
}
