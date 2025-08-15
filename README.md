# DCIT 318 – Assignment 3

This project is a comprehensive implementation of five distinct systems, each addressing a specific problem domain. The solutions are implemented as a .NET C# console application, following modular design principles and best practices.

---

## **Project Structure**

```
DCIT318Assignment3/
├── ConsoleApplication/
│   ├── FinanceManagement/
│   ├── HealthcareSystem/
│   ├── WarehouseInventory/
│   ├── SchoolGradingSystem/
│   ├── InventoryRecords/
│   └── Program.cs
├── ConsoleApplication.sln
└── README.md
```

---

## **Implemented Systems**

### **Q1: Finance Management System**
- **Description**: Manages financial transactions using records, interfaces, and inheritance.
- **Key Features**:
  - `Transaction` record and `ITransactionProcessor` interface.
  - Processors: `BankTransferProcessor`, `MobileMoneyProcessor`, `CryptoWalletProcessor`.
  - `Account` and `SavingsAccount` classes for transaction handling.
  - Demonstrated in `Program.cs`.

### **Q2: Healthcare System**
- **Description**: Manages patients and prescriptions using generics and collections.
- **Key Features**:
  - Generic `Repository<T>` for managing entities.
  - Entities: `Patient` and `Prescription`.
  - Data grouping with a prescription map.
  - Demonstrated in `Program.cs`.

### **Q3: Warehouse Inventory Management**
- **Description**: Manages inventory items with custom exceptions and interfaces.
- **Key Features**:
  - `IInventoryItem` interface and entities: `ElectronicItem`, `GroceryItem`.
  - `InventoryRepository<T>` for inventory management.
  - Custom exceptions: `DuplicateItemException`, `ItemNotFoundException`, `InvalidQuantityException`.
  - Demonstrated in `Program.cs`.

### **Q4: School Grading System**
- **Description**: Processes student grades using file I/O and custom exceptions.
- **Key Features**:
  - `Student` entity with a `GetGrade()` method.
  - Custom exceptions: `InvalidScoreFormatException`, `MissingFieldException`.
  - `StudentResultProcessor` for reading and writing student data.
  - Demonstrated in `Program.cs`.

### **Q5: Inventory Records with Records & File Storage**
- **Description**: Manages inventory records with file persistence.
- **Key Features**:
  - `InventoryItem` record and `IInventoryEntity` interface.
  - `InventoryLogger<T>` for managing inventory logs.
  - `InventoryApp` for seeding, saving, loading, and printing inventory data.
  - Demonstrated in `Program.cs`.

---

## **How to Run**

1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```

2. Open the solution in Visual Studio or your preferred IDE.

3. Build the solution to restore dependencies.

4. Run the application to test each system.

---

## **File Descriptions**

- **`Program.cs`**: Entry point of the application. Demonstrates the functionality of all five systems.
- **`FinanceManagement/`**: Contains the implementation for Q1.
- **`HealthcareSystem/`**: Contains the implementation for Q2.
- **`WarehouseInventory/`**: Contains the implementation for Q3.
- **`SchoolGradingSystem/`**: Contains the implementation for Q4.
- **`InventoryRecords/`**: Contains the implementation for Q5.

---

## **Contact**
For any questions or feedback, please contact the repository owner.
