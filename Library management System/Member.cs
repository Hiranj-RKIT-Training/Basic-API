

namespace Library_management_System
{
    internal class Member: User
    {
        public Member(string name, string email) : base(name, email) { }
        public void BorrowItem(IBorrowable item)
        {
            Console.WriteLine($"{Name} is borrowing:");
            item.borrow();
        }
        public override void ShowUserInfo()
        {
            base.ShowUserInfo();
            Console.WriteLine("Role: Member");
        }

    }
}
