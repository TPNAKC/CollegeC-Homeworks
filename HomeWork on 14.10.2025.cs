Console.WriteLine("Введите первую сторону треугольника:");
int cornerOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника:");
int cornerTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника:");
int cornerThree = Convert.ToInt32(Console.ReadLine());
if (cornerOne + cornerTwo > cornerThree)
{
    Console.WriteLine($"Данный треугольник существует");
    if (cornerOne == cornerTwo)
    {
        Console.WriteLine("Данный треугольник равнобедренный");
    }
    else if ((cornerOne == cornerTwo) && (cornerOne == cornerThree) && (cornerTwo == cornerThree))
    {
        Console.WriteLine("Данный треугольник равносторонний");

    }
    else if ((cornerOne != cornerTwo) && (cornerOne != cornerThree) && (cornerTwo != cornerThree))
    {
        Console.WriteLine("Данный треугольник разносторонний");
    }

    else
    {

    }

}
else
{
    Console.WriteLine("Данного треугольника не существует");
}
