

namespace Collection_Demo
{
    internal class ListDemo
    {
        /// <summary>
        /// contains the demo of the list methods
        /// </summary>
        public static void ListMain()
        {
            /// <summary>
            ///  checks wether the number is even or not
            ///  </summary>
            ///  <params name = 'x'>
            ///     integer
            /// </params>
            /// <returns>
            /// returns bool 
            /// </returns>
            bool IsEven(int x)
            {
                return (x & 1) == 0;
            }
            //created list of integers
            List<int> lstNums = new List<int>();
            //adding numbers to list
            lstNums.Add(1);
            lstNums.Add(2);
            lstNums.Add(3);
            lstNums.Add(4);
            lstNums.Add(5);
            //checking the capacity of the list
            Console.WriteLine("Capacity Is: " + lstNums.Capacity);
            //checking the no of elements present in list
            Console.WriteLine("Count Is: " + lstNums.Count);
            //iterating list through foreach
            Program.PrintCollection(lstNums);
            lstNums.Add(6);
            lstNums.Add(7);
            lstNums.Add(8);
            lstNums.Add(9);
            Console.WriteLine("Capacity Is: " + lstNums.Capacity);
            Console.WriteLine("Count Is: " + lstNums.Count);
            //searching in the list
            Console.WriteLine("seaching 6: " + lstNums.BinarySearch(6));
            //checking wehter number contains in list or not
            Console.WriteLine("checking if lstNums contains 10 or not : " + lstNums.Contains(10));
            //finds the first element which matches the condition
            Console.WriteLine(lstNums.Find(IsEven));
            //finds all the elements which matches the condition
            List<int> lstEvens = lstNums.FindAll(IsEven);

            Console.WriteLine("printing all evens");
            Program.PrintCollection(lstNums);
            //gives index of the element
            Console.WriteLine("index of 3 is " + lstNums.IndexOf(3));
            //removing element
            lstNums.Remove(5);
            Program.PrintCollection(lstNums);
            //removing Element at 1st position
            lstNums.RemoveAt(1);
            Program.PrintCollection(lstNums);
            //reversing list
            lstNums.Reverse();
            Program.PrintCollection(lstNums);
            //sorting list
            lstNums.Sort();
            Program.PrintCollection(lstNums);
        }

    }
}
