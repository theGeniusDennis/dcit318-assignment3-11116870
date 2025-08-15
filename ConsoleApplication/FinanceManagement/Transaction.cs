namespace ConsoleApplication.FinanceManagement;

// Represents a financial transaction
public record Transaction(int Id, DateTime Date, decimal Amount, string Category);
