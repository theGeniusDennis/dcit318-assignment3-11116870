using ConsoleApplication.FinanceManagement;

// Create instances of transaction processors
var bankProcessor = new BankTransferProcessor();
var mobileProcessor = new MobileMoneyProcessor();
var cryptoProcessor = new CryptoWalletProcessor();

// Create sample transactions
var transactions = new[]
{
    new Transaction(1, DateTime.Now, 100.00m, "Groceries"),
    new Transaction(2, DateTime.Now, 200.00m, "Utilities"),
    new Transaction(3, DateTime.Now, 300.00m, "Entertainment")
};

// Process transactions
foreach (var transaction in transactions)
{
    bankProcessor.Process(transaction);
    mobileProcessor.Process(transaction);
    cryptoProcessor.Process(transaction);
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
