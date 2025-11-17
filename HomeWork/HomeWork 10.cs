class Program
{
    static void Main()
    {
        string data = "  иванов иван,петров   петр,   сидорова    Анна,   бобров  БОРИС  ";
        string[] rawPairs = data.Split(',');

        Console.WriteLine("--- Форматирование списка пользователей ---");
        Console.WriteLine($"Исходная строка: \"{data}\"");
        Console.WriteLine("Отформатированный список:");

        for (int i = 0; i < rawPairs.Length; i++)
        {
            string pair = rawPairs[i].Trim();

            string[] parts = pair.Split(' ');

            List<string> filteredParts = new List<string>();
            foreach (var p in parts)
            {
                if (!string.IsNullOrWhiteSpace(p))
                    filteredParts.Add(p);
            }

            if (filteredParts.Count == 2)
            {
                string lastName = Capitalize(filteredParts[0]);
                string firstName = Capitalize(filteredParts[1]);
                Console.WriteLine($"{i + 1}. {lastName} {firstName}");
            }
        }
    }

    static string Capitalize(string word)
    {
        if (word.Length == 0)
            return word;

        string firstChar = word[0].ToString().ToUpper();

        string rest = "";
        for (int i = 1; i < word.Length; i++)
        {
            rest += word[i].ToString().ToLower();
        }
        return firstChar + rest;
    }
}

