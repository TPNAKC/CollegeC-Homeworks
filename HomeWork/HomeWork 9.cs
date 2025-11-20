class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Иван", new Book("Горе от Ума", "А.С.Грибоедов"));
        Console.WriteLine($"Создан студент: {student1.Name}");
        Console.WriteLine($"Начальное количество студентов в системе: {Student.ObjectCount}");

        Student student2 = new Student("Анна", new Book("Капитанская дочка", "А.С. Пушкин"));
        Console.WriteLine($"Создан студент: {student2.Name}");
        Console.WriteLine($"Начальное количество студентов в системе: {Student.ObjectCount}");

        Student student3 = new Student("Андрей", new Book("Маленький принц", "Сент-Экзюпери"));
        Console.WriteLine($"Создан студент: {student3.Name}");
        Console.WriteLine($"Начальное количество студентов в системе: {Student.ObjectCount}");
        Console.WriteLine($"\nПервый студент: {student1.Name}, книга: {student1.FavoriteBook.NameBook} автор: {student1.FavoriteBook.Creator}");

        Student copiedStudent = student1;

        Book copiedBook = student1.FavoriteBook;

        copiedStudent.Name = "Петр";
        copiedBook.NameBook = "Властелин колец";

        Console.WriteLine("\nИзменение:");
        Console.WriteLine($"{student1.Name}, с '{student1.FavoriteBook.NameBook}' на '{copiedBook.NameBook}'");

    }

}
public struct Book
{
    public string NameBook { get; set; }

    public string Creator { get; set; }

    public Book(string nameBook, string creator)
    {
        NameBook = nameBook;
        Creator = creator;
    }

}
public class Student
{
    private static int _objectCount = 0;

    public static int ObjectCount
    {
        get { return _objectCount; }
    }
    public string Name { get; set; }

    public Book FavoriteBook { get; set; }

    public Student(string name, Book favoritebook)
    {
        Name = name;
        FavoriteBook = favoritebook;
        _objectCount++;
    }
}
