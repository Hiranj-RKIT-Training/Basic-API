namespace Collection_Demo
{
    internal class HashSetDemo
    {
        public static void HashSetMain()
        {
            HashSet<int> setNums = new HashSet<int>();
            setNums.Add(5);
            setNums.Add(5);
            setNums.Add(10);
            setNums.Add(20);
            setNums.Add(2);
            setNums.Add(3);
            Program.PrintCollection(setNums);
            setNums.Remove(10);
            Program.PrintCollection(setNums);
        }
    }
}
