using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    public class Library
    {
        private List<Book> _books = new List<Book>()
    {
        new Book { Id = 0, Title = "Капитанская дочка", Author = "Александр Сергеевич Пушкин", Year = 1836},
        new Book { Id = 1, Title = "Горе от ума", Author = "Александр Сергеевич Грибоедов", Year = 1824},
        new Book { Id = 2, Title = "Недоросль", Author = "Денис Иванович Фонвизин", Year = 1782},
    };

        private int _nextId = 3;

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
        public void HandleAddBook()
        {
            try
            {
                Console.WriteLine("Напишите название книги, автора и год книги:");
                Console.WriteLine("Название:");
                string title = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Автор:");
                string author = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Год:");
                int year = Convert.ToInt32(Console.ReadLine());
                _books.Add(new Book { Id = _nextId++, Title = title, Author = author, Year = year });
                Console.WriteLine($"Книга добавлена! Название: {title}, Автор: {author}, Год: {year}");
            }
            catch (System.FormatException)
            {
                Console.WriteLine($"Ошибка: Вы сделали что-то не так.");
                Console.ReadLine();
            }
        }
        public void ViewLibrary()
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
            Console.ReadLine();
        }
        public void BookSearch()
        {
            Library book = new Library();
            Console.WriteLine("По какому критерию вы бы хотели найти книгу?");
            Console.WriteLine("1. По названию");
            Console.WriteLine("2. По автору");
            string choice1 = Convert.ToString(Console.ReadLine());
            switch (choice1)
            {
                case "1":
                    Console.WriteLine("Напишите название книги(Напишите без инициал, тоесть полностью.):");
                    string title1 = Convert.ToString(Console.ReadLine());
                    book.SearchByTitle(title1);
                    break;
                case "2":
                    Console.WriteLine("Напишите автора книги(Напишите без инициал, тоесть полностью.):");
                    string author1 = Convert.ToString(Console.ReadLine());
                    book.SearchByAuthor(author1);
                    break;
            }
        }
        public void HandleRemoveBook()
        {
            Library book = new Library();
            try
            {
                Console.WriteLine("Какую книгу вы хотите удалить?");
                Console.WriteLine("Напишите ID книги:");
                int removeId = Convert.ToInt32(Console.ReadLine());
                int idToRemove = removeId;
                Book bookToRemove = _books.FirstOrDefault(book => book.Id == idToRemove);

                if (bookToRemove != null)
                {
                    _books.Remove(bookToRemove);
                }
                Console.WriteLine($"Книга удалена!");
                Console.ReadLine();
            }
            catch (System.FormatException)
            {
                Console.WriteLine($"Ошибка: Введите только число.");
                Console.ReadLine();
            }
        }
        public void Exit()
        {
            Console.WriteLine("Досвидание.");
            Console.ReadLine();
        }
        private void RemoveBook(int removeId)
        {
            int idToRemove = removeId;
            Book bookToRemove = _books.FirstOrDefault(book => book.Id == idToRemove);

            if (bookToRemove != null)
            {
                _books.Remove(bookToRemove);
            }
        }
        private void SearchByTitle(string title)
        {
            try
            {
                if (title != null)
                {
                    Book Title = _books.Single(book => book.Title == title);
                    Console.WriteLine($"Id: {Title.Id}, Название: {Title.Title}, Автор: {Title.Author}, Год: {Title.Year} ");
                }
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("Книга не найдена.");
            }
        }
        private void SearchByAuthor(string author)
        {
            try
            {
                if (author != null)
                {
                    Book Author = _books.Single(book => book.Author == author);
                    Console.WriteLine($"Id: {Author.Id}, Название: {Author.Title}, Автор: {Author.Author}, Год: {Author.Year} ");
                }
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("Книга не найдена.");
            }
        }
    }
}
