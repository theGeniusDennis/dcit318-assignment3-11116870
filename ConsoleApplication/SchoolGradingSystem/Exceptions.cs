namespace ConsoleApplication.SchoolGradingSystem;

// Exception for invalid score format
public class InvalidScoreFormatException : Exception
{
    public InvalidScoreFormatException(string message) : base(message) { }
}

// Exception for missing fields
public class MissingFieldException : Exception
{
    public MissingFieldException(string message) : base(message) { }
}
