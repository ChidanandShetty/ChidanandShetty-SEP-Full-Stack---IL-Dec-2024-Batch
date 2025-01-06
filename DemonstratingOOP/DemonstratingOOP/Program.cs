class Program
{
    static void Main()
    {
        Instructor profJohn = new Instructor("John Doe", new DateTime(1980, 5, 10), 50000, new DateTime(2005, 8, 1));
        Student alice = new Student("Alice", new DateTime(2002, 3, 15));
        Student bob = new Student("Bob", new DateTime(2001, 7, 20));

        Course cs101 = new Course("Computer Science 101");
        cs101.EnrollStudent(alice);
        cs101.EnrollStudent(bob);

        Department csDepartment = new Department("Computer Science", profJohn, 100000);
        csDepartment.AddCourse(cs101);

        alice.AddGrade('A');
        alice.AddGrade('B');
        bob.AddGrade('C');

        Console.WriteLine($"{profJohn.CalculateAge()} years old professor earns ${profJohn.CalculateSalary()} per year.");
        Console.WriteLine($"{alice.CalculateAge()} years old Alice has GPA: {alice.CalculateGPA()}");
    }
}