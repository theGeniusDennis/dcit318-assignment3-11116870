namespace ConsoleApplication.FinanceManagement;

// Processes bank transfer transactions
public class BankTransferProcessor : ITransactionProcessor
{
    public void Process(Transaction transaction)
    {
        Console.WriteLine($"Bank Transfer: Processed {transaction.Amount:C} for {transaction.Category}.");
    }
}
