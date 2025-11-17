public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();

        student1.FirstName = "Иван ";
        student1.LastName = "Петров";
        student1.Age = 19;

        Student student2 = new Student();

        student2.FirstName = "Анна ";
        student2.LastName = "Сидорова";
        student2.Age = 20;

        Console.WriteLine("--- Знакомство со студентами ---");
        student1.Introduce();
        student2.Introduce();

        Console.ReadLine();
    }
}
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    private int _age;
    public int Age {
        set
        {
            if (value <= 0)
            {
                Age = value;
            }
        }
        get { return _age; }
    }
    public string FullName
    {
        get { return FirstName + LastName; }
    }
    public void Introduce()
    {
        Console.WriteLine($"Привет, меня зовут {FirstName} {LastName}, мне {Age} лет.");
    }
    public void Introduce2() 
    {
        Console.WriteLine($"Полное Имя: {FullName}");
    }
}