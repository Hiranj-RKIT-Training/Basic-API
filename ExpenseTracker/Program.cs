using Newtonsoft.Json;
using System.Data;
namespace ExpenseTracker
{
    internal class Program
    {
        //Enum for Expenses Categories
        public enum enmCategories { Food, Entertainment, Education, Healthcare, Housing }
        // counter for the expense id
        static int expenseIdCounter = 1;
        // static file path for loading and saving files
        static string filePath = "./expenses.json";

        // Manager to handle expense operations
        static FinancialManager manager = new FinancialManager();

        static void Main(string[] args)
        {
            // main loop for inputs 
            while (true)
            {
                Console.WriteLine("\nExpense Tracker");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Edit Expense");
                Console.WriteLine("4. Delete Expense");
                Console.WriteLine("5. Summary");
                Console.WriteLine("6. Save Expenses to File");
                Console.WriteLine("7. Load Expenses from File");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                // handling menu options
                switch (Console.ReadLine())
                {
                    case "1":
                        AddExpense(); // adding new expense 
                        break;
                    case "2":
                        ViewExpenses(); // viewing expenses
                        break;
                    case "3":
                        EditExpense(); // editing expenses
                        break;
                    case "4":
                        DeleteExpense(); // deleting expenses
                        break;
                    case "5":
                        ShowSummary(); // summary of expenses
                        break;
                    case "6":
                        SaveExpensesToFile(); // saving expenses to json
                        break;
                    case "7":
                        LoadExpensesFromFile();  // loading expenses from json 
                        break;
                    case "8":
                        Console.WriteLine("Exiting..."); // exiting application 
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

            }
            /// <summary>
            /// Adds a new expense to the system.
            /// Prompts the user for details such as date, category, amount, and description.
            /// </summary>
            static void AddExpense()
            {
                try
                {
                    Console.WriteLine("\nAdd Expense");
                    Expense expense = new Expense { Id = expenseIdCounter++ };

                    Console.Write("Enter Date (yyyy-mm-dd): ");
                    if (!DateTime.TryParse(Console.ReadLine(), out var date))
                    {
                        throw new FormatException("Invalid date format.");
                    }
                    expense.Date = date;

                    Console.WriteLine("Select Category:");
                    foreach (var category in Enum.GetValues(typeof(enmCategories)))
                    {
                        Console.WriteLine($"{(int)category}. {category}");
                    }
                    if (!int.TryParse(Console.ReadLine(), out var categorySelection) || !Enum.IsDefined(typeof(enmCategories), categorySelection))
                    {
                        throw new ArgumentException("Invalid category selection.");
                    }
                    expense.Category = (enmCategories)categorySelection;

                    Console.Write("Enter Amount: ");
                    if (!double.TryParse(Console.ReadLine(), out var amount) || amount <= 0)
                    {
                        throw new ArgumentException("Amount must be a positive number.");
                    }
                    expense.Amount = amount;

                    Console.Write("Enter Description: ");
                    expense.Description = Console.ReadLine();

                    manager.AddRecord(expense);
                    Console.WriteLine("Expense added successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            /// <summary>
            /// Displays all expenses in a tabular format.
            /// </summary>

            static void ViewExpenses()
            {
                Console.WriteLine("\nView Expenses");

                // Create a DataTable to hold expense data
                DataTable expenseTable = new DataTable();

                // Define columns for the DataTable
                expenseTable.Columns.Add("ID", typeof(int));
                expenseTable.Columns.Add("Date", typeof(string));
                expenseTable.Columns.Add("Category", typeof(string));
                expenseTable.Columns.Add("Amount", typeof(string));
                expenseTable.Columns.Add("Description", typeof(string));

                // Populate the DataTable with expense data
                foreach (var record in manager.GetAllRecords().OfType<Expense>())
                {
                    expenseTable.Rows.Add(
                        record.Id,
                        record.Date.ToString("yyyy-MM-dd"), // Format the date
                        record.Category.ToString(),
                        record.Amount.ToString(), // Format the amount as currency
                        record.Description
                    );
                }

                // Display the DataTable contents in a tabular format
                Console.WriteLine("ID    | Date       | Category        | Amount     | Description");
                Console.WriteLine(new string('-', 60));

                foreach (DataRow row in expenseTable.Rows)
                {
                    Console.WriteLine($"{row["ID"],-5} | {row["Date"],-10} | {row["Category"],-15} | {row["Amount"],10} | {row["Description"]}");
                }
            }
            /// <summary>
            /// Allows the user to edit an existing expense by ID.
            /// </summary>
            static void EditExpense()
            {
                try
                {
                    Console.WriteLine("\nEdit Expense");
                    Console.Write("Enter Expense ID: ");
                    if (!int.TryParse(Console.ReadLine(), out var id))
                    {
                        throw new ArgumentException("Invalid ID format.");
                    }

                    var record = manager.GetRecordById(id);
                    if (record == null || record is not Expense expense)
                    {
                        Console.WriteLine("Expense not found.");
                        return;
                    }

                    Console.WriteLine("Current Details: " + expense);

                    Console.Write("Enter New Date (leave blank to keep current): ");
                    var dateInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(dateInput) && !DateTime.TryParse(dateInput, out var result))
                    {
                        throw new FormatException("Invalid date format.");
                    }
                    if (!string.IsNullOrEmpty(dateInput))
                    {
                        expense.Date = DateTime.Parse(dateInput);
                    }
                    Console.Write("Enter New Amount (leave blank to keep current): ");
                    var amountInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(amountInput) && (!double.TryParse(amountInput, out var newAmount) || newAmount <= 0))
                    {
                        throw new ArgumentException("Amount must be a positive number.");
                    }
                    if (!string.IsNullOrEmpty(amountInput)) expense.Amount = double.Parse(amountInput);

                    Console.Write("Enter New Description (leave blank to keep current): ");
                    var descriptionInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(descriptionInput)) expense.Description = descriptionInput;

                    manager.UpdateRecord(id, expense);
                    Console.WriteLine("Expense updated successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            /// <summary>
            /// Deletes an expense by ID.
            /// </summary>
            static void DeleteExpense()
            {
                try
                {
                    Console.WriteLine("\nDelete Expense");
                    Console.Write("Enter Expense ID: ");
                    if (!int.TryParse(Console.ReadLine(), out var id))
                    {
                        throw new ArgumentException("Invalid ID format.");
                    }

                    var record = manager.GetRecordById(id);
                    if (record == null)
                    {
                        Console.WriteLine("Expense not found.");
                        return;
                    }

                    manager.DeleteRecord(id);
                    Console.WriteLine("Expense deleted successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            /// <summary>
            /// Displays a summary of expenses grouped by category with their total amounts.
            /// </summary>
            static void ShowSummary()
            {
                Console.WriteLine("\nExpense Summary");
                var expenses = manager.GetAllRecords().OfType<Expense>();
                var categorySummary = expenses
                    .GroupBy(e => e.Category)
                    .Select(g => new { Category = g.Key, Total = g.Sum(e => e.Amount) });

                foreach (var summary in categorySummary)
                {
                    Console.WriteLine($"{summary.Category,-15}: {summary.Total:C}");
                }
            }
            /// <summary>
            /// Saves all expenses to a JSON file.
            /// </summary>
            static void SaveExpensesToFile()
            {
                try
                {
                    var expenses = manager.GetAllRecords().OfType<Expense>().ToList();
                    string json = JsonConvert.SerializeObject(expenses, Formatting.Indented);
                    File.WriteAllText(filePath, json);
                    Console.WriteLine("Expenses saved to file.");
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
            /// <summary>
            /// Loads expenses from a JSON file and populates the system.
            /// </summary>

            static void LoadExpensesFromFile()
            {
                try
                {
                    if (!File.Exists(filePath))
                    {
                        Console.WriteLine("No previous expenses found.");
                        return;
                    }

                    string json = File.ReadAllText(filePath);
                    var expenses = JsonConvert.DeserializeObject<List<Expense>>(json);

                    manager.DeleteAllRecords();  // Clear existing records
                    foreach (var expense in expenses)
                    {
                        manager.AddRecord(expense);
                    }
                    Console.WriteLine("Expenses loaded from file.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }

        }
    }
}
