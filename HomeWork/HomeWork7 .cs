public class Program
{
    public static void Main(string[] args)
    {
        Rectangle number1 = new Rectangle();
        number1.width = 11;
        number1.height = 4.5;

        Rectangle number2 = new Rectangle();

        number2.width = 6;
        number2.height = 7.5;

        double number3 = number1.GetArea();
        double number4 = number1.GetPerimeter();
        double number5 = number2.GetArea();
        double number6 = number2.GetPerimeter();
        Print("Прямоугольник:1 ");
        Print($"Ширина: {number1.width}");
        Print($"Высота: {number1.height}");
        Print($"Площадь: {number3}");
        Print($"Периметр: {number4}");

        Print("Прямоугольник:2 ");
        Print($"Ширина: {number2.width}");
        Print($"Высота: {number2.height}");
        Print($"Площадь: {number5}");
        Print($"Периметр: {number6}");
    }
    public static void Print(string s)
    {
        Console.WriteLine(s);
    }
    public static void Print(double s)
    {
        Console.WriteLine(s);
    }
}
public class Rectangle
{
   public double width;
   public double height;

   public double GetArea()
   {
     return width * height;
   }
   public double GetPerimeter()
   {
     return (width + height) * 2;
   }
}
