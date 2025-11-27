using System.Reflection;
using System.LINQ;
using static System.Reflection.Metadata.BlobBuilder;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в приложение.");
        Console.ReadLine();
        Console.WriteLine("Что вы хотите сделать?");
        Console.WriteLine("1. Добавить книгу");
        Console.WriteLine("2. Просмотр библиотеки");
        Console.WriteLine("3. Поиск книг");
        Console.WriteLine("4. Удаление книг");
        Console.WriteLine("5. Выход");

        // Объект с помощью которого мы можем использовать методы класса Library
        Library book = new Library();
        string choice = Convert.ToString(Console.ReadLine());

        switch (choice)
        {
            case "1":
                Console.WriteLine("Напишите название книги, автора и год книги:");
                Console.WriteLine("Название:");
                string title = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Автор:");
                string author = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Год:");
                int year = Convert.ToInt32(Console.ReadLine());
                book.AddBook(title, author, year);
                Console.WriteLine($"Книга добавлена! Название: {title}, Автор: {author}, Год: {year}");
                Console.ReadLine();
                Console.WriteLine("Текущая библиотека:");
                book.LibraryAndBooks();
                break;
            case "2":
                book.LibraryAndBooks();
                break;
            case "3":
                Console.WriteLine("По какому критерию вы бы хотели найти книгу?");
                Console.WriteLine("1. По названию");
                Console.WriteLine("2. По автору");
                string choice1 = Convert.ToString(Console.ReadLine());
                switch (choice1)
                {
                    case "1":
                        Console.WriteLine("Напишите название книги:");
                        string title1 = Convert.ToString(Console.ReadLine());
                        book.SearchByAuthor(title1);
                        break;
                    case "2":
                        Console.WriteLine("Напишите автора книги:");
                        string author1 = Convert.ToString(Console.ReadLine());
                        book.SearchByTitle(author1);
                        break;
                }
                break;
            case "4":
                Console.WriteLine("Какую книгу вы хотите удалить?");
                Console.WriteLine("Напишите название книги:");
                string removeTitle = Convert.ToString(Console.ReadLine());
                book.RemoveBook(removeTitle);
                Console.ReadLine();
                Console.WriteLine("Текущая библиотека:");
                book.LibraryAndBooks();
                break;
            case "5":
                Console.WriteLine("Увидимся ещё!");
                Console.ReadLine();
                break;
        }
    }
}
public class Library
{
    private List<Book> _books = new List<Book>(); // Приватный Лист
    private int _nextId = 100000; // Начальное Id

    // Добавление книги
    public void AddBook(string title, string author, int year)
    {
        _books.Add(new Book { Id = _nextId++, Title = title, Author = author, Year = year });
    }
    // Просмотр библиоткеки
    public void LibraryAndBooks()
    {
        if (_books.Count == 0)
        {
            Console.WriteLine("Библиотека пустая.");
            return;
        }
        foreach (var book in _books)
        {
            Console.WriteLine($"Библиотека: \nID: {book.Id}, Название: {book.Title}, Автор: {book.Author}, Год: {book.Year}");
        }
    }
    // Нахождение книги по названию 
    public void SearchByTitle(string title)
    {
        var book = _books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            Console.WriteLine($"Найдена книга: {book.Title} автор: {book.Author}");
        }
        else
        {
            Console.WriteLine("Книга не найдена.");
        }
    }
    // Нахождение книги по автору
    public void SearchByAuthor(string author)
    {
        {
            var results = _books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
            if (results.Count > 0)
            {
                foreach (var book in results)
                {
                    Console.WriteLine($"Книга: {book.Title} автор: {book.Author}");
                }
            }
            else
            {
                Console.WriteLine("Книга не найдена.");
            }
        }
    }
    // Удаление книги по названию
    public void RemoveBook(string removeTitle)
    {
        var book = _books.FirstOrDefault(book => book.Title == removeTitle);
        if (book != null)
        {
            _books.Remove(book);
            Console.WriteLine("Книга удалена.");
        }
        else
        {
            Console.WriteLine("Книга не найдена.");
        }
    }
}      
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
}
