using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Book
    {
        public int BookID { get; set; }
        public string BookType { get; set; }
        public string BookName { get; set; }
        public int Number { get; set; }

        public Book(int bookId, string booktype, string bookname, int number)
        {
            BookID = bookId;
            BookType = booktype;
            BookName = bookname;
            Number = number;
        }
        public override string ToString()
        {
            return $"Book with Book ID={BookID}, Book Type={BookType}, Book Name ={BookName} with number is {Number}";
        }
    }
}
