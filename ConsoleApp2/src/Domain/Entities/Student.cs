namespace ConsoleApp2.Domain.Entities;

public class Student
{
    private string _email;
    private string _phoneNumber;

    public required string Name { get; set; }
    public required string Surname { get; set; }
    public DateOnly BirthDate { get; set; }

    public string Email
    {
        get => _email;
        set
        {
            if (!value.Contains("@"))
                throw new ArgumentException("Invalid email address");
            _email = value;
        }
    }

    public string Phone
    {
        get => _phoneNumber;
        set
        {
            if (value.Length > 13 || value[0] != '+' && value.Length == 13)
                throw new ArgumentException("invalid number");

            for (int i = 1; i < value.Length; i++)
                if (!char.IsDigit(value[i]))
                    throw new ArgumentException("invalid number");

            _phoneNumber = value;
        }
    }

    public Dictionary<string, List<int>> SubjectGrades { get; set; } = [];

    public double GetAverage()
    {
        if (SubjectGrades is null)
            throw new NullReferenceException($"{nameof(Student.SubjectGrades)} is null");

        double sum = 0;
        int count = 0;

        foreach (var grades in SubjectGrades.Values)
        {
            sum += grades.Sum();
            count += grades.Count;
        }

        return sum / count;
    }

    public double GetAverage(string subject)
    {
        if (SubjectGrades is null)
            throw new NullReferenceException($"{nameof(Student.SubjectGrades)} is null");

        if (!SubjectGrades.ContainsKey(subject))
            throw new ArgumentException($"Collection doesn't contain key: {subject}");

        return SubjectGrades[subject].Average();
    }
}