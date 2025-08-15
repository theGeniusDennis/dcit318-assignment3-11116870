namespace ConsoleApplication.WarehouseInventory;

// Represents a grocery inventory item
public class GroceryItem : IInventoryItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public DateTime ExpiryDate { get; set; }
}
