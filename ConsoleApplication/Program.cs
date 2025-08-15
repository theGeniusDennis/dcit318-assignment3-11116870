using ConsoleApplication.FinanceManagement;
using ConsoleApplication.HealthcareSystem;
using ConsoleApplication.WarehouseInventory;
using ConsoleApplication.SchoolGradingSystem;
using ConsoleApplication.InventoryRecords;

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

// Healthcare System Integration
var app = new HealthSystemApp();

// Seed data and build prescription map
app.SeedData();
app.BuildPrescriptionMap();

// Print all patients
Console.WriteLine("All Patients:");
app.PrintAllPatients();

// Print prescriptions for a specific patient
Console.WriteLine("\nPrescriptions for Patient with ID 1:");
app.PrintPrescriptionsForPatient(1);

// Warehouse Inventory Integration
var manager = new WareHouseManager();

// Seed data
manager.SeedData();

// Print all electronic items
Console.WriteLine("\nElectronic Items:");
manager.PrintAllItems(manager.Electronics);

// Print all grocery items
Console.WriteLine("\nGrocery Items:");
manager.PrintAllItems(manager.Groceries);

// Test increasing stock
Console.WriteLine("\nIncreasing stock for electronic item with ID 1:");
manager.IncreaseStock(manager.Electronics, 1, 5);
manager.PrintAllItems(manager.Electronics);

// Test removing an item
Console.WriteLine("\nRemoving grocery item with ID 2:");
manager.RemoveItemById(manager.Groceries, 2);
manager.PrintAllItems(manager.Groceries);

// School Grading System Integration
var processor = new StudentResultProcessor();

// File paths
string inputFilePath = "students.csv";
string outputFilePath = "report.txt";

try
{
    // Read students from file
    var students = processor.ReadStudentsFromFile(inputFilePath);

    // Write report to file
    processor.WriteReportToFile(students, outputFilePath);

    Console.WriteLine("Student report generated successfully.");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (InvalidScoreFormatException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (ConsoleApplication.SchoolGradingSystem.MissingFieldException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}

// Inventory Records Integration
var inventoryApp = new InventoryApp("inventory.json");

// Seed sample data
inventoryApp.SeedSampleData();

// Save data to file
inventoryApp.SaveData();
Console.WriteLine("Data saved to file.");

// Clear in-memory log and load data from file
inventoryApp.LoadData();
Console.WriteLine("Data loaded from file.");

// Print all items
inventoryApp.PrintAllItems();
