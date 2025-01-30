namespace Collection_Demo
{
    internal class FileInfoDemo
    {
        public static void FileInfoMain()
        {
            String currentPath = Environment.CurrentDirectory;
            String fullPath = Path.GetFullPath("a.txt", currentPath);
            Console.WriteLine(fullPath);

            FileInfo fileInfo = new FileInfo(fullPath);

            // Check if the file exists
            if (!fileInfo.Exists)
            {
                // Create a new file
                using (fileInfo.Create()) { }
                Console.WriteLine("File created.");
            }
            // Display file properties
            Console.WriteLine($"File Name: {fileInfo.Name}");
            Console.WriteLine($"File Size: {fileInfo.Length} bytes");

            // writing  in the file with streamwriter
            StreamWriter sw = fileInfo.CreateText();
            sw.WriteLine("hello world");
            sw.Close();

            // reading from file with streamreader
            StreamReader sr = fileInfo.OpenText();
            Console.WriteLine(sr.ReadLine());

        }
    }
}
