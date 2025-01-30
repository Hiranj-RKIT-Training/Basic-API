namespace Collection_Demo
{
    internal class StackDemo
    {
        public static void StachMain()
        {
            Stack<int> stknums = new Stack<int>();
            stknums.Push(1);
            stknums.Push(2);
            stknums.Push(3);
            stknums.Push(4);
            Program.PrintCollection(stknums);
            stknums.Pop();
            Console.WriteLine(stknums.Peek());
        }
    }
}
