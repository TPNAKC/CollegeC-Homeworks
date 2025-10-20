Console.WriteLine("--- Улучшенный калькулятор ---");
Console.WriteLine("Введите первое число:");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите символ операции:");
double result1 = number1 + number2;
double result2 = number1 - number2;
double result3 = number1 * number2;
double result4 = number1 / number2;
Console.WriteLine("1. +");
Console.WriteLine("2. -");
Console.WriteLine("3. *");
Console.WriteLine("4. /");
int sign = Convert.ToInt32(Console.ReadLine());
double result = 0;
switch (sign)
{
    case 1:
        result = result1;
        break;
    case 2:
        result = result2;
        break;
    case 3:
        result = result3;
        break;
    case 4:
        result = result4;
        break;
    default:
        Console.WriteLine("Пожалуйста выберите один из предоставленных знаков. ");
        return;
}
if (result4 == 0)
{
    Console.WriteLine("Ошибка. Деление на 0 невозможно");
}
else
{
    Console.WriteLine($"Результат: {result}");
}


