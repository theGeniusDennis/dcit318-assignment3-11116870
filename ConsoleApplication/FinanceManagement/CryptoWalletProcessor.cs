namespace ConsoleApplication.FinanceManagement;

// Processes cryptocurrency wallet transactions
public class CryptoWalletProcessor : ITransactionProcessor
{
    public void Process(Transaction transaction)
    {
        Console.WriteLine($"Crypto Wallet: Processed {transaction.Amount:C} for {transaction.Category}.");
    }
}
