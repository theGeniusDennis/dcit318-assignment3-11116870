namespace ConsoleApplication.FinanceManagement;

// Processes mobile money transactions
public class MobileMoneyProcessor : ITransactionProcessor
{
    public void Process(Transaction transaction)
    {
        Console.WriteLine($"Mobile Money: Processed {transaction.Amount:C} for {transaction.Category}.");
    }
}
