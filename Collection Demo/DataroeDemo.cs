using System.Data;

namespace Collection_Demo
{
    internal class DataroeDemo
    {
        public static void DataRowMain()
        {

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));

            // Create a new DataRow
            DataRow newRow = table.NewRow();
            newRow["ID"] = 1;
            newRow["Name"] = "John Doe";

            // Add the DataRow to the DataTable
            table.Rows.Add(newRow);

            // Accessing DataRow properties
            Console.WriteLine($"ID: {newRow["ID"]}, Name: {newRow["Name"]}");
        }
    }

}
