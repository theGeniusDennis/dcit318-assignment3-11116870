namespace ConsoleApplication.SchoolGradingSystem;

// Represents a student entity
public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public decimal Score { get; set; }

    // Returns the grade based on the score
    public string GetGrade()
    {
        return Score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            >= 50 => "E",
            _ => "F"
        };
    }
}
