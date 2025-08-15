using System.Globalization;

namespace ConsoleApplication.SchoolGradingSystem;

// Processes student results
public class StudentResultProcessor
{
    public List<Student> ReadStudentsFromFile(string path)
    {
        var students = new List<Student>();

        foreach (var line in File.ReadLines(path))
        {
            var fields = line.Split(',');
            if (fields.Length != 3)
            {
                throw new MissingFieldException("Each line must have exactly 3 fields: Id, FullName, Score.");
            }

            if (!int.TryParse(fields[0], out var id))
            {
                throw new InvalidScoreFormatException("Invalid Id format.");
            }

            if (!decimal.TryParse(fields[2], NumberStyles.Number, CultureInfo.InvariantCulture, out var score))
            {
                throw new InvalidScoreFormatException("Invalid Score format.");
            }

            students.Add(new Student { Id = id, FullName = fields[1], Score = score });
        }

        return students;
    }

    public void WriteReportToFile(List<Student> students, string path)
    {
        using var writer = new StreamWriter(path);
        foreach (var student in students)
        {
            writer.WriteLine($"Id: {student.Id}, Name: {student.FullName}, Score: {student.Score}, Grade: {student.GetGrade()}");
        }
    }
}
