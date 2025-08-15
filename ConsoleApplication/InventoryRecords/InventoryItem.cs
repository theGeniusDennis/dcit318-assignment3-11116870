namespace ConsoleApplication.InventoryRecords;

// Represents an inventory item
public record InventoryItem(int Id, string Name, int Quantity, DateTime DateAdded) : IInventoryEntity;
