class Student : Person, IStudentService
{
    private List<char> Grades = new List<char>();

    public Student(string name, DateTime birthDate) : base(name, birthDate) { }

    public void AddGrade(char grade)
    {
        Grades.Add(grade);
    }

    public double CalculateGPA()
    {
        if (Grades.Count == 0) return 0;
        Dictionary<char, double> gradePoints = new Dictionary<char, double> { { 'A', 4.0 }, { 'B', 3.0 }, { 'C', 2.0 }, { 'D', 1.0 }, { 'F', 0.0 } };
        double totalPoints = 0;
        foreach (var grade in Grades) totalPoints += gradePoints[grade];
        return totalPoints / Grades.Count;
    }

    public override decimal CalculateSalary() => 0; // Students don't have salaries
}

class Instructor : Person, IInstructorService
{
    private decimal BaseSalary;
    private DateTime JoinDate;
    public bool IsHead { get; set; }

    public Instructor(string name, DateTime birthDate, decimal baseSalary, DateTime joinDate) : base(name, birthDate)
    {
        BaseSalary = baseSalary;
        JoinDate = joinDate;
    }

    public override decimal CalculateSalary()
    {
        int experienceYears = DateTime.Now.Year - JoinDate.Year;
        return BaseSalary + (experienceYears * 1000); // Bonus per year
    }
}