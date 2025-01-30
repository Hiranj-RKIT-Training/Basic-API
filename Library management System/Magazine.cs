

namespace Library_management_System
{
    internal class Magazine : LibraryItem, IBorrowable
    {
        public string IssueNumber { get; set; }

        public Magazine(string name, string author, string issueNumber) : base(name, author)
        {
            IssueNumber = issueNumber;
        }
        public void borrow()
        {
            Console.WriteLine($"The book with {Title} (Issue {IssueNumber}) has been borrowed");

        }

        public override void CheckOut()
        {
            Console.WriteLine($"The book with {Title} (Issue {IssueNumber}) has been checked out");
        }

        public override void Return()
        {
            Console.WriteLine($"The book with {Title} (Issue {IssueNumber}) has been returned");
        }
    }
}
