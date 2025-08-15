namespace ConsoleApplication.HealthcareSystem;

// Generic repository for managing entities
public class Repository<T>
{
    private readonly List<T> _items = new();

    public void Add(T item) => _items.Add(item);

    public List<T> GetAll() => _items;

    public T? GetById(Func<T, bool> predicate) => _items.FirstOrDefault(predicate);

    public void Remove(Func<T, bool> predicate)
    {
        var item = _items.FirstOrDefault(predicate);
        if (item != null)
        {
            _items.Remove(item);
        }
    }
}
