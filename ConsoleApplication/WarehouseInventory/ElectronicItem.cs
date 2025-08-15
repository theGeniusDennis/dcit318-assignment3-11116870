namespace ConsoleApplication.WarehouseInventory;

// Represents an electronic inventory item
public class ElectronicItem : IInventoryItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string Brand { get; set; } = string.Empty;
    public int WarrantyMonths { get; set; }
}
