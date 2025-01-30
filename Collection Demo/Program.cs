namespace Collection_Demo
{
    internal class Program
    {
        public static void PrintCollection(dynamic collection)
        {
            foreach (dynamic i in collection)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //ListDemo.ListMain();
            //HashSetDemo.HashSetMain();
            //StackDemo.StachMain();
            //QueueDemo.QueueMain();
            //ArrayListDemo.ArrayLsitMain();
            //JaggedArrayDemo.JaggedMain();
            //UserAuth auth = new UserAuth();

            //Console.WriteLine("Enter Username:");
            //string inputUsername = Console.ReadLine();

            //Console.WriteLine("Enter Password:");
            //string inputPassword = Console.ReadLine();

            //if (auth.Validate(inputUsername, inputPassword))
            //{
            //    Console.WriteLine("Authentication successful!");
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed.");
            //}
            //FileInfoDemo.FileInfoMain();
            //DirectoryInfoDemo.directoryInfoMain();
            //StringDemo.StringDemoMain();
            //DateTimeDemo.DateTimeDemoMain();
            //Datacloumn.dataColumnMain();
            //DataroeDemo.DataRowMain();
            DatatableDemo.DatatableMain();

        }
    }
}
