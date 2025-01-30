using System.Collections;

namespace Collection_Demo
{
    static internal class ArrayListDemo
    {
        public static void ArrayLsitMain()
        {
            ArrayList lstnums = new ArrayList();
            lstnums.Add(1);
            lstnums.Add("hello");
            Program.PrintCollection(lstnums);
            Console.WriteLine(lstnums.Count);
        }
    }
}
