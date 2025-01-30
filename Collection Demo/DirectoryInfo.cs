namespace Collection_Demo
{
    internal class DirectoryInfoDemo
    {
        public static void directoryInfoMain()
        {
            String path = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                Console.WriteLine("Directory already exist.");
            }
            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine($"File Name: {file.Name}, Size: {file.Length} bytes");
            }

        }
    }
}
