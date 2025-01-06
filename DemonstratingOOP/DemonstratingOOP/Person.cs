abstract class Person
{
    private string Name;
    private DateTime BirthDate;
    private List<string> Addresses = new List<string>();

    public Person(string name, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }

    public int CalculateAge()
    {
        return DateTime.Now.Year - BirthDate.Year;
    }

    public void AddAddress(string address)
    {
        Addresses.Add(address);
    }

    public void DisplayAddresses()
    {
        Console.WriteLine($"{Name}'s Addresses: {string.Join(", ", Addresses)}");
    }

    public abstract decimal CalculateSalary(); // Polymorphism
}
