public class Student
{
    private string _email;
 
    private string _phone;
    public required string Name { get; set; }
 
    public required string Surname { get; set; }
 
    public DateOnly Birthday { get; set; }
 
    public string Email
    {
        get => _email;
        set
        {
            if (!value.Contains("@"))
                throw new ArgumentException("Invalid email");
 
            _email = value;
        }
    }
 
    public string Phone 
    {
        get => _phone;
        set
        {
            if (value.Length > 13 || value[0] != '+' && value.Length == 13)
                throw new ArgumentException("invalid number");
 
            for(int i = 1; i < value.Length; i++)
                if (!char.IsDigit(value[i]))
                    throw new ArgumentException("invalid number");
 
            _phone = value;
        }
    }
 
    public Dictionary<string, List<int>> SubjectGrades { get; set; } = []; // "= []"
}