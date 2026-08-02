using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Book
    {
        private bool _isAvailable=true;

        public bool IsAvailable { get { return _isAvailable; } }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public void BorrowBook()
        {
            if (_isAvailable) _isAvailable = false;
            else Console.WriteLine("sorry book is not available");
        }
        public void ReturnBook()
        {
            _isAvailable = true;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Book {Title} with {PageCount} pages by {Author} is {(_isAvailable?"":"not ")}Available");
        }
    }
}
