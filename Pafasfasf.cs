using System;
using static Library;
class Program
{
    public static void Main(string[] args)
    {
        Library book = new Library();
        book.ShowMenu();
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
                book.ViewLibrary();
                break;
            case "2":
                book.LibraryAndBooks();
                Console.ReadLine();
                break;
            case "3":
                book.TitleOrAuthour();
                break;
            case "4":
                book.TextRemoveBook();
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
    private List<Book> _books = new List<Book>() // Приватный Лист
    {
        new Book {Id = 0, Title = "Капитанская дочка", Author = "Александр Сергеевич Пушкин", Year = 1836},
        new Book {Id = 1, Title = "Горе от ума", Author = "Александр Сергеевич Грибоедов", Year = 1824},
        new Book {Id = 2, Title = "Недоросль", Author = "Денис Иванович Фонвизин", Year = 1782},
    };
    private int _nextId = 3; // Начальное Id

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
        if (title != null)
        {
            Book Title = _books.Single(book => book.Title == title);
            Console.WriteLine($"Id: {Title.Id}, Название: {Title.Title}, Автор: {Title.Author}, Год: {Title.Year} ");
        }
        else
        {
            Console.WriteLine("Книга не найдена");
        }
    }
    // Нахождение книги по автору
    public void SearchByAuthor(string author)
    {
        if (author != null)
        {
            Book Author = _books.Single(book => book.Author == author);
            Console.WriteLine($"Id: {Author.Id}, Название: {Author.Title}, Автор: {Author.Author}, Год: {Author.Year} ");
        }
        else
        {
            Console.WriteLine("Книга не найдена");
        }
    }
    // Удаление книги по названию
    public void RemoveBook(int removeId)
    {
        Library book = new Library();
        Book Id = _books.Single(book => book.Id == removeId);
        Console.WriteLine($"Id: {Id.Id}, Название: {Id.Title}, Автор: {Id.Author}, Год: {Id.Year} ");
    }
    // Меню
    public void ShowMenu()
    {
        Console.WriteLine("Добро пожаловать в приложение.");
        Console.ReadLine();
        Console.WriteLine("Что вы хотите сделать?");
        Console.WriteLine("1. Добавить книгу");
        Console.WriteLine("2. Просмотр библиотеки");
        Console.WriteLine("3. Поиск книг");
        Console.WriteLine("4. Удаление книг");
        Console.WriteLine("5. Выход");
    }
    // Выбор "Хотите посмотреть библиотеку?"
    public void ViewLibrary()
    {
        Library book = new Library();
        Console.WriteLine("Вы хотите посмотреть библиотеку?");
        Console.WriteLine("1. Да");
        Console.WriteLine("2. Нет");
        string choice2 = Convert.ToString(Console.ReadLine());
        switch (choice2)
        {
            case "1":
                book.LibraryAndBooks();
                Console.ReadLine();
                break;
            case "2":
                Console.WriteLine("Увидимся!");
                Console.ReadLine();
                break;
        }
    }
    public void TitleOrAuthour()
    {
        Library book = new Library();
        Console.WriteLine("По какому критерию вы бы хотели найти книгу?");
        Console.WriteLine("1. По названию");
        Console.WriteLine("2. По автору");
        string choice1 = Convert.ToString(Console.ReadLine());
        switch (choice1)
        {
            case "1":
                Console.WriteLine("Напишите название книги:");
                string title1 = Convert.ToString(Console.ReadLine());
                book.SearchByTitle(title1);
                break;
            case "2":
                Console.WriteLine("Напишите автора книги:");
                string author1 = Convert.ToString(Console.ReadLine());
                book.SearchByAuthor(author1);
                break;
        }
    }
    public void TextRemoveBook()
    {
        Library book = new Library();
        Console.WriteLine("Какую книгу вы хотите удалить?");
        Console.WriteLine("Напишите ID книги:");
        int removeId = Convert.ToInt32(Console.ReadLine());
        book.RemoveBook(removeId);
        Console.WriteLine($"Книга удалена!");
        Console.ReadLine();
        book.ViewLibrary();
    }
}
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
}