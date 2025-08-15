using System.Text.Json;

namespace ConsoleApplication.InventoryRecords;

// Logger for managing inventory records
public class InventoryLogger<T> where T : IInventoryEntity
{
    private readonly List<T> _log = new();
    private readonly string _filePath;

    public InventoryLogger(string filePath)
    {
        _filePath = filePath;
    }

    public void Add(T item)
    {
        _log.Add(item);
    }

    public List<T> GetAll() => new List<T>(_log);

    public void SaveToFile()
    {
        var json = JsonSerializer.Serialize(_log, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filePath, json);
    }

    public void LoadFromFile()
    {
        if (File.Exists(_filePath))
        {
            var json = File.ReadAllText(_filePath);
            var items = JsonSerializer.Deserialize<List<T>>(json);
            if (items != null)
            {
                _log.Clear();
                _log.AddRange(items);
            }
        }
    }
}
