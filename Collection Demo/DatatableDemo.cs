using System.Data;

namespace Collection_Demo
{
    internal class DatatableDemo
    {
        public static void DatatableMain()
        {
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("EmpId", typeof(string));
            dataTable1.Columns.Add("EmpName", typeof(string));

            // Add rows to first DataTable
            dataTable1.Rows.Add("EMP001", "Ajaj Kumar");
            dataTable1.Rows.Add("EMP002", "Sanjay Gupta");

            // Create second DataTable
            DataTable dataTable2 = new DataTable();
            dataTable2.Columns.Add("EmpId", typeof(string));
            dataTable2.Columns.Add("Salary", typeof(int));

            // Add rows to second DataTable
            dataTable2.Rows.Add("EMP001", 50000);
            dataTable2.Rows.Add("EMP002", 45000);

            // Merge DataTables
            // Create a new DataTable for the merged result
            DataTable mergedDataTable = dataTable1.Copy();

            // Set primary key for both tables
            mergedDataTable.PrimaryKey = new DataColumn[] { mergedDataTable.Columns["EmpId"] };

            // Merge second table into the first
            mergedDataTable.Merge(dataTable2, false, MissingSchemaAction.Add);

            // Display merged results
            foreach (DataRow row in mergedDataTable.Rows)
            {
                Console.WriteLine($"EmpId: {row["EmpId"]}, EmpName: {row["EmpName"]}, Salary: {(row.Table.Columns.Contains("Salary") ? row["Salary"].ToString() : "N/A")}");

            }
        }
    }
}
