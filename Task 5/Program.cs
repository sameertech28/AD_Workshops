class Program
{
    static void Main()
    {
        DateTime birthdate = new DateTime(2003, 08, 28);
        DateTime currentDate = DateTime.Now;

        TimeSpan ageSpan = currentDate - birthdate;
        int age = (int)(ageSpan.TotalDays / 365.25);

        Console.WriteLine($"Birthdate: {birthdate:d}");
        Console.WriteLine($"Current date: {currentDate}");
        Console.WriteLine($"Age: {age} years");

        DateTime birthdateplus10 = birthdate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 days: {birthdateplus10:d}");
    }
}