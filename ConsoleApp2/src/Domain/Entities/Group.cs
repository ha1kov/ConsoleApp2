namespace ConsoleApp2.Domain.Entities;

public class Group
{
    public required string Name { get; set; }

    public List<Student> Students { get; set; } = [];
    
    public string Curator { get; set; }

    public double GetGradesAverage()
    {
        return 0;
    }
    
    public double GetGradesAverage(string SubjectNamr) // перевантаження методів -
        // це коли є методи з
        // однаковою назвою,
        // вле різним списком вхідних параметрів
    {
        return 0;
    }
}