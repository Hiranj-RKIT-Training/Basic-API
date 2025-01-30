using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_System
{
    internal class Book : LibraryItem, IBorrowable
    {
        public string ISBN { get; set; }

        public Book(String title, String author, String isbn ):base(title, author)
        {
            ISBN = isbn;
        }
        public void borrow()
        {
            Console.WriteLine($"The book with {Title} has been chekout");
        }  

        public override void CheckOut()
        {
            Console.WriteLine($"The book with {Title} has been chekout");
        }

        public override void Return()
        {
            Console.WriteLine($"The book with {Title} has been returned");
        }
    }
}
