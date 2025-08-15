namespace ConsoleApplication.WarehouseInventory;

// Exception for duplicate items
public class DuplicateItemException : Exception
{
    public DuplicateItemException(string message) : base(message) { }
}

// Exception for item not found
public class ItemNotFoundException : Exception
{
    public ItemNotFoundException(string message) : base(message) { }
}

// Exception for invalid quantity
public class InvalidQuantityException : Exception
{
    public InvalidQuantityException(string message) : base(message) { }
}
