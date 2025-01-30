using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_System
{
    internal class Librarian:User
    {
        public Librarian(string name, string email) : base(name, email) { }

        public void AddItemToLibrary(Library library, LibraryItem item)
        {
            library.AddItem(item);
            Console.WriteLine($"{Name} added '{item.Title}' to the library.");

        }
        public override void ShowUserInfo()
        {
            base.ShowUserInfo();
            Console.WriteLine("Role: Librarian");
        }
    }
}
