namespace ExpenseTracker
{
    /// <summary>
    /// Manages financial operations, including adding, deleting, updating, 
    /// and retrieving expense records.
    /// </summary>
    internal class FinancialManager : iFinancialOperations
    {
        /// <summary>
        /// Internal list of expense records.
        /// </summary>
        private List<Expense> lstRecords = new List<Expense>();

        /// <summary>
        /// Adds a new expense record to the list.
        /// </summary>
        /// <param name="record">The expense record to be added.</param>
        public void AddRecord(Expense record)
        {
            lstRecords.Add(record);
        }

        /// <summary>
        /// Deletes an expense record by its unique ID.
        /// </summary>
        /// <param name="id">The unique ID of the expense to delete.</param>
        public void DeleteRecord(int id)
        {
            Expense? record = GetRecordById(id);
            if (record != null)
            {
                lstRecords.Remove(record);
            }
        }

        /// <summary>
        /// Retrieves all expense records.
        /// </summary>
        /// <returns>
        /// A collection of all expense records.
        /// </returns>
        public IEnumerable<Expense> GetAllRecords()
        {
            return lstRecords;
        }

        /// <summary>
        /// Retrieves a specific expense record by its unique ID.
        /// </summary>
        /// <param name="id">The unique ID of the expense to retrieve.</param>
        /// <returns>
        /// The expense record if found; otherwise, null.
        /// </returns>
        public Expense? GetRecordById(int id)
        {
            return lstRecords.Find(r => r.Id == id);
        }

        /// <summary>
        /// Updates an existing expense record by its unique ID.
        /// </summary>
        /// <param name="id">The unique ID of the expense to update.</param>
        /// <param name="updatedRecord">The updated expense record.</param>
        public void UpdateRecord(int id, Expense updatedRecord)
        {
            Expense? record = GetRecordById(id);
            if (record != null)
            {
                record.Amount = updatedRecord.Amount;
                record.Date = updatedRecord.Date;
                record.Category = updatedRecord.Category;
                record.Description = updatedRecord.Description;
            }
        }

        /// <summary>
        /// Deletes all expense records from the list.
        /// </summary>
        public void DeleteAllRecords()
        {
            lstRecords.Clear();
        }
    }
}
