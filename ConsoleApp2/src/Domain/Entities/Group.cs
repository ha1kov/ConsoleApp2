namespace ConsoleApp2.Domain.Entities;

public class Group
{
    public required string Name { get; set; }

    public List<Student> Students { get; set; } = [];
    
    public string Curator { get; set; }

    public double GetGradesAverage()
    {
        if (Students is null)
            throw new NullReferenceException($"null reference {nameof(Group.Students)}");
        double average = 0;
        foreach (var student in Students)
        {
            average += student.GetAverage();
        }
        return average;
    }
    
    public double GetGradesAverage(string SubjectNamr) // перевантаження методів -
        // це коли є методи з
        // однаковою назвою,
        // вле різним списком вхідних параметрів
    {
        return 0;
    }
}