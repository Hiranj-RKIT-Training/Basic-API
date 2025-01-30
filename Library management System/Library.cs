
namespace Library_management_System
{
    internal class Library
    {
        private List<LibraryItem> items;

        public Library()
        {
            items = new List<LibraryItem>();
        }
        public void AddItem(LibraryItem item)
        {
            items.Add(item);
        }

        public void DisplayItems()
        {
            Console.WriteLine("Library Items:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.Title} by {item.Author}");
            }
        }
    }
}
