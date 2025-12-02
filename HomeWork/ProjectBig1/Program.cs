using ConsoleApp23;
using System;
using static System.Reflection.Metadata.BlobBuilder;
class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();
        while (true)
        {
            library.ShowMenu();
            string choice = Convert.ToString(Console.ReadLine());
            switch (choice)
            {
                case "1":
                    library.HandleAddBook();
                    continue;
                case "2":
                    library.ViewLibrary();
                    break;
                case "3":
                    library.BookSearch();
                    break;
                case "4":
                    library.HandleRemoveBook();
                    break;
                case "5":
                    library.Exit();
                    return;
            }
        }
    }
}