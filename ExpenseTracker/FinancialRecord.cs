namespace ExpenseTracker
{
    /// <summary>
    /// Represents a generic financial record with common properties.
    /// Serves as a base class for specific financial record types.
    /// </summary>
    internal abstract class FinancialRecord
    {
        /// <summary>
        /// Gets or sets the unique identifier for the financial record.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the amount associated with the financial record.
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the date of the financial record.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
