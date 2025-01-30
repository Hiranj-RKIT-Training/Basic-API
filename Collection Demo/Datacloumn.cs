using System.Data;

namespace Collection_Demo
{
    internal class Datacloumn
    {
        public static void dataColumnMain()
        {
            // Create a new DataTable
            DataTable table = new DataTable("SampleTable");

            // Create a new DataColumn
            DataColumn idColumn = new DataColumn("ID", typeof(int));
            idColumn.AllowDBNull = false; // Disallow nulls

            // Add the DataColumn to the DataTable
            table.Columns.Add(idColumn);

            // Create another column
            DataColumn nameColumn = new DataColumn("Name", typeof(string));
            table.Columns.Add(nameColumn);

            Console.WriteLine($"Columns in {table.TableName}:");
            foreach (DataColumn col in table.Columns)
            {
                Console.WriteLine($"- {col.ColumnName} ({col.DataType})");
            }
        }
    }
}
