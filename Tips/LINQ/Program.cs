using ConsoleApp20;

class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>
    {
        new Product { Name = "Ноутбук", Category = "Электроника", Price = 85000, Stock = 15 },
        new Product { Name = "Смартфон", Category = "Электроника", Price = 60000, Stock = 35 },
        new Product { Name = "Кофемашина", Category = "Бытовая техника", Price = 25000, Stock = 20 },
        new Product { Name = "Джинсы", Category = "Одежда", Price = 4500, Stock = 50 },
        new Product { Name = "Чайник", Category = "Бытовая техника", Price = 3000, Stock = 42 },
        new Product { Name = "Книга 'C# для профи'", Category = "Книги", Price = 2100, Stock = 120 },
        new Product { Name = "Кроссовки", Category = "Одежда", Price = 7800, Stock = 25 }
    };

        Console.ReadLine();

        Console.WriteLine("--- Товары из 'Электроника' ---");
        var electronics = products.Where(product => product.Category == "Электроника");

        foreach (var product in electronics)
        {
            Console.WriteLine($"{product.Name} - {product.Price} руб.");
        }

        Console.WriteLine("\n--- Все названия товаров ---");
        var productNames = products.Select(product => product.Name);

        foreach (var name in productNames)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\n--- Товары, отсортированные по цене ---");
        var sortedByPrice = products.OrderBy(poducts => poducts.Price);

        foreach (var product in sortedByPrice)
        {
            Console.WriteLine($"{product.Name} - {product.Price} руб.");
        }

        Console.WriteLine("\n--- Одежда в наличии (>30 шт), отсортированная по названию ---");
        var clothingInStock = products
            .Where(product => product.Category == "Одежда" && product.Stock > 30)
            .OrderBy(product => product.Name)
            .Select(poduct => poduct.Name);

        foreach (var name in clothingInStock)
        {
            Console.WriteLine(name);
        }
        Console.ReadLine ();
    }
}