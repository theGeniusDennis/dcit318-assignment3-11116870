namespace ConsoleApplication.WarehouseInventory;

// Manages warehouse inventory
public class WareHouseManager
{
    private readonly InventoryRepository<ElectronicItem> _electronics = new();
    private readonly InventoryRepository<GroceryItem> _groceries = new();

    public void SeedData()
    {
        _electronics.AddItem(new ElectronicItem { Id = 1, Name = "Laptop", Quantity = 10, Brand = "Dell", WarrantyMonths = 24 });
        _electronics.AddItem(new ElectronicItem { Id = 2, Name = "Smartphone", Quantity = 20, Brand = "Samsung", WarrantyMonths = 12 });

        _groceries.AddItem(new GroceryItem { Id = 1, Name = "Milk", Quantity = 50, ExpiryDate = DateTime.Now.AddDays(7) });
        _groceries.AddItem(new GroceryItem { Id = 2, Name = "Bread", Quantity = 30, ExpiryDate = DateTime.Now.AddDays(3) });
    }

    public void PrintAllItems<T>(InventoryRepository<T> repository) where T : IInventoryItem
    {
        foreach (var item in repository.GetAllItems())
        {
            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Quantity: {item.Quantity}");
        }
    }

    public void IncreaseStock<T>(InventoryRepository<T> repository, int id, int quantity) where T : IInventoryItem
    {
        try
        {
            var item = repository.GetItemById(id);
            item.Quantity += quantity;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void RemoveItemById<T>(InventoryRepository<T> repository, int id) where T : IInventoryItem
    {
        try
        {
            repository.RemoveItem(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public InventoryRepository<ElectronicItem> Electronics => _electronics;
    public InventoryRepository<GroceryItem> Groceries => _groceries;
}
