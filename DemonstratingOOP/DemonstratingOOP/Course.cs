class Course
{
    public string Name { get; set; }
    private List<Student> EnrolledStudents = new List<Student>();

    public Course(string name)
    {
        Name = name;
    }

    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
    }

    public void DisplayStudents()
    {
        Console.WriteLine($"Students enrolled in {Name}: {string.Join(", ", EnrolledStudents)}");
    }
}

class Department
{
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    private List<Course> Courses = new List<Course>();

    public Department(string name, Instructor head, decimal budget)
    {
        Name = name;
        Head = head;
        Budget = budget;
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }
}
