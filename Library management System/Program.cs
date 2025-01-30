namespace Library_management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book b1 = new Book("Harry Potter", "J K Rowling","1234");
            Magazine m1 = new Magazine("Times new Magazine", "Times India", "1235");

            Member member = new Member("Hiranj", "kotalkhiranj8694@gmai.com");
            Librarian librarian = new Librarian("Henil", "Henil@gmail.com");

            librarian.AddItemToLibrary(library,b1);
            librarian.AddItemToLibrary(library, m1);

            library.DisplayItems();

            member.BorrowItem(b1);
            member.BorrowItem(m1);

            librarian.ShowUserInfo();
            member.ShowUserInfo();

        }
    }
}
