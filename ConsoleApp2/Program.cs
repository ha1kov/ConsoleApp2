using ConsoleApp2;
using ConsoleApp2.Domain.Entities;

var students = new List<Student>
{
    new Student
    {
        Name = "Elon",
        Surname = "Musk",
        BirthDate = new DateOnly(2007, 5, 12),
        Email = "elonmusk@starlink.com",
        Phone = "+380111111111",
        SubjectGrades =
        {
            ["Math"] = new List<int> { 10, 11, 12 },
            ["Physics"] = new List<int> { 12, 13 },
            ["Ukrainian"] = new List<int> { 11, 12 }
        }
    },

    new Student
    {
        Name = "Steve",
        Surname = "Jobs",
        BirthDate = new DateOnly(2006, 11, 3),
        Email = "stevejobs@icloud.com",
        Phone = "+380977777777",
        SubjectGrades =
        {
            ["Math"] = new List<int> { 12, 12, 11 },
            ["English"] = new List<int> { 10, 11, 12 },
            ["Biology"] = new List<int> { 9, 10 }
        }
    },

    new Student
    {
        Name = "Pavel",
        Surname = "Durov",
        BirthDate = new DateOnly(2007, 2, 27),
        Email = "andriy.koval@example.com",
        Phone = "+380633334455",
        SubjectGrades =
        {
            ["History"] = new List<int> { 10, 9, 11 },
            ["Math"] = new List<int> { 8, 9 },
            ["Chemistry"] = new List<int> { 11, 10 }
        }
    },

    new Student
    {
        Name = "Sofiia",
        Surname = "Melnyk",
        BirthDate = new DateOnly(2007, 9, 15),
        Email = "sofia.melnyk@example.com",
        Phone = "+380503217890",
        SubjectGrades =
        {
            ["English"] = new List<int> { 12, 12, 12 },
            ["Ukrainian"] = new List<int> { 11, 12, 12 }
        }
    }
}; 

var Group10_1 = new Group()
{
    Name = "Group10_1",
    Students = students,
    Curator = "Anstasiya Melashenko"
};

Console.WriteLine($"{Group10_1.GetGradesAverage().ToString("f2")}");