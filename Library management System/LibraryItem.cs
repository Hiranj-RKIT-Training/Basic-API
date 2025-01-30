using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_System
{
    abstract internal class LibraryItem
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public LibraryItem(string title, string author)
        {
            Title = title;
            Author = author;
        }   

        public abstract void CheckOut();
        public abstract void Return();
    }
}
