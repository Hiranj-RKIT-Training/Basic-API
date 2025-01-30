using static ExpenseTracker.Program;

namespace ExpenseTracker
{
    /// <summary>
    /// Represents a specific expense record.
    /// Inherits from the <see cref="FinancialRecord"/> base class.
    /// </summary>
    internal sealed class Expense : FinancialRecord
    {
        /// <summary>
        /// Gets or sets the category of the expense.
        /// </summary>
        public enmCategories Category { get; set; }

        /// <summary>
        /// Gets or sets a description of the expense.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Returns a string representation of the expense.
        /// </summary>
        /// <returns>
        /// A string formatted as "Id | Date | Category | Amount | Description".
        /// </returns>
        public override string ToString()
        {
            return $"{Id} | {Date} | {Category} | {Amount} | {Description}";
        }
    }
}
