using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Book
    {
        private string _title;
        private string _author;
        private int _page;

        public void SetBook(string title, string author, int page)
        {
            _title = title;
            _author = author;
            _page = page;
        }
        public void PrintBook()
        {
            Console.WriteLine($"Book {_title} by {_author} has {_page} pages");
        }
    }
}
