namespace Collection_Demo
{
    internal class QueueDemo
    {
        public static void QueueMain()
        {
            Queue<int> qNumns = new Queue<int>();
            qNumns.Enqueue(1);
            qNumns.Enqueue(2);
            qNumns.Enqueue(3);
            qNumns.Enqueue(4);
            Program.PrintCollection(qNumns);
            qNumns.Dequeue();
            Console.WriteLine(qNumns.Peek());
        }
    }
}
