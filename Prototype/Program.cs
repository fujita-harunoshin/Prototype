namespace Prototype;

internal class Program
{
    static void Main(string[] args)
    {
        Person p1 = new()
        {
            Age = 42,
            BirthDate = Convert.ToDateTime("1977-01-01"),
            Name = "Jack Daniels",
            IdInfo = new IdInfo(666)
        };

        var p2 = p1.ShallowCopy();
        var p3 = p1.DeepCopy();

        Console.WriteLine("Original values of p1, p2, p3:");
        Console.WriteLine("   p1 instance values: ");
        DisplayValues(p1);
        Console.WriteLine("   p2 instance values:");
        DisplayValues(p2);
        Console.WriteLine("   p3 instance values:");
        DisplayValues(p3);

        p1.Age = 32;
        p1.BirthDate = Convert.ToDateTime("1900-01-01");
        p1.Name = "Frank";
        p1.IdInfo.IdNumber = 7878;
        Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
        Console.WriteLine("   p1 instance values: ");
        DisplayValues(p1);
        Console.WriteLine("   p2 instance values (reference values have changed):");
        DisplayValues(p2);
        Console.WriteLine("   p3 instance values (everything was kept the same):");
        DisplayValues(p3);

    }

    public static void DisplayValues(Person p)
    {
        Console.WriteLine($"Name: {p.Name}, Age: {p.Age}, BirthDate: {p.BirthDate:MM/dd/yy}");
        Console.WriteLine($"ID: {p.IdInfo.IdNumber}");
    }
}
