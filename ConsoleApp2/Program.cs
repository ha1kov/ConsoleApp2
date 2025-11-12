using ConsoleApp2.Domain.Entities;

var Tymurhaikov = new Student()
{
    Name = "tymur",
    Surname = "Haikov",
    Birthday = new DateOnly(1990, 1, 1),
    Email = "ha1kov@icloud.com",
    Phone = "06969696969",
    SubjectGrades = new() { "Math", new() [1, 3, 4,]}
};