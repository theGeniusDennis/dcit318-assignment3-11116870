namespace ConsoleApplication.WarehouseInventory;

// Interface for inventory items
public interface IInventoryItem
{
    int Id { get; }
    string Name { get; }
    int Quantity { get; set; }
}
