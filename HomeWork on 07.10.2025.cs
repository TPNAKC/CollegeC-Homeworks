Console.WriteLine("--- Калькулятор Индекса Массы Тела (ИМТ) ---"); 
Console.WriteLine("Введите ваш вес в килограммах:");
string weightInput = Console.ReadLine();
double weightResult = Convert.ToDouble(weightInput);
Console.WriteLine("Введите ваш рост в метрах:"); // Дробные числа вводить ТОЛЬКО через запятую,иначе код не будет работать и выдаст ошибку.
string heightInput = Console.ReadLine();
double heightResults = Convert.ToDouble(heightInput);
double quotient = weightResult / (heightResults * heightResults);
Console.WriteLine("--- Ваш результат ---");
Console.WriteLine($"При весе {weightResult} и росте {heightResults}, ваш ИМТ составляет: {quotient}");
Console.ReadLine();
