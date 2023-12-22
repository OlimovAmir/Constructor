
class Program
{
    static void Main(string[] args)
    {
        Constructor.Point point = new Constructor.Point(x: 5, y: 15);
        point.Print();

        Constructor.Student student1 = new Constructor.Student("Olimov", new DateTime(1987, 01, 13));

        Constructor.Student student2 = new Constructor.Student(student1);
        student1.SetLastName("Ilhom");
        student1.Print();

        Console.WriteLine();

        student2.Print();
    }
}