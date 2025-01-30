namespace ExpenseTracker
{
    /// <summary>
    /// Interface for defining financial operations related to expense management.
    /// </summary>
    internal interface iFinancialOperations
    {
        /// <summary>
        /// Adds a new expense record.
        /// </summary>
        /// <param name="record">The expense record to be added.</param>
        void AddRecord(Expense record);

        /// <summary>
        /// Deletes an expense record by its unique ID.
        /// </summary>
        /// <param name="id">The unique ID of the expense to be deleted.</param>
        void DeleteRecord(int id);

        /// <summary>
        /// Updates an existing expense record.
        /// </summary>
        /// <param name="id">The unique ID of the expense to be updated.</param>
        /// <param name="updatedRecord">The updated expense record.</param>
        void UpdateRecord(int id, Expense updatedRecord);

        /// <summary>
        /// Retrieves a specific expense record by its unique ID.
        /// </summary>
        /// <param name="id">The unique ID of the expense to retrieve.</param>
        /// <returns>
        /// The expense record if found; otherwise, null.
        /// </returns>
        Expense? GetRecordById(int id);

        /// <summary>
        /// Retrieves all expense records.
        /// </summary>
        /// <returns>
        /// An enumerable collection of all expense records.
        /// </returns>
        IEnumerable<Expense> GetAllRecords();
    }
}
