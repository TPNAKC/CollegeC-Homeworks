using System.Reflection;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в приложение.");
        Console.WriteLine("Что вы хотите сделать?");
        Console.WriteLine("1. Добавить книгу");
        Console.WriteLine("2. Просмотр каталога");
        Console.WriteLine("3. Поиск книг");
        Console.WriteLine("4. Удаление книг");
        string choice = Convert.ToString(Console.ReadLine());
        
        switch (choice)
        {
            case "1":
                Console.WriteLine("Напишите СНАЧАЛО название книги, автора и год книги:");
                string title = Convert.ToString (Console.ReadLine());
                string author = Convert.ToString(Console.ReadLine());
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Книга добавлена! Книга: {title},{author},{year}");
                break;
            case "2":
                
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
        }
    }
}
public class Library
{
    private List<Book> _books = new List<Book>()
    {
        new Book {Id = 100, Title = "Капитанская дочка", Author = "А.С.Пушкин", Year = 1836},
        new Book {Id = 101, Title = "Горе от ума", Author = "А.С.Грибоедов", Year = 1824},
        new Book {Id = 102, Title = "Сказа о рыбаке и рыбке", Author = "А.С.Пушкин", Year = 1833},
        new Book {Id = 103, Title = "Недоросль", Author = "Д.И.Фонвизин", Year = 1782},
    };
    public void AddBook(string title, string author, int year)
    {
        _books.Add(new Book  {Title = title, Author = author, Year = year});
    }
    public List<Book> FindAllBooks()
    {
        foreach (Book book in _books)
        {
            Console.WriteLine($"Книги: {book}");
        }
        return _books;
    } 
}
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

}
