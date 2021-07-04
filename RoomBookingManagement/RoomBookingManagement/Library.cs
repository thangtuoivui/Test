using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Library
    {
        public string Library_Name { get; set;}
        public List<Book> Books { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Order> Orders { get; set; }

        public Library(string libraryName)
        {
            Library_Name = libraryName;
            Books = new List<Book>();
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Orders = new List<Order>();
        }
        public bool IsBook(List<Book> books, string name)
        {
            foreach (var b in books)
            {
                if (b.BookName == name)
                        return true;
            }
            return false;
        }
        public int take_Book_Id(List<Book> books, string name)
        {
            foreach (var b in books)
            {
                if (b.BookName == name)
                    return b.BookID-1;
            }
            return 0;
        }
        public bool IsCount(List<Book> books, string name, int number)
        {
            foreach (var b in books)
            {
                if(IsBook(books, name))
                {
                    if (b.Number >= number)
                    {
                        b.Number = b.Number - number;
                        return true;
                    }
                }    
            }
            return false;
        }
        public List<Book> SearchAvailableBook()
        {
            List<Book> availableBooks = new List<Book>();
            foreach (var b in Books)
            {
                if (IsCount(Books, b.BookName, 1))
                {
                    availableBooks.Add(b);
                }
            }
            return availableBooks;
        }
        public void ShowListBook()
        {
            foreach (var b in Books)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"ID : {b.BookID}");
                Console.WriteLine($"Book name : {b.BookName}");
                Console.WriteLine($"Book type : {b.BookType}");
                Console.WriteLine($"Number remain : {b.Number}");
            }
        }
        public void DeleteBook(List<Book> books)
        {
            Console.WriteLine("-----------------");
            Console.Write("Book name for delete: ");
            string name = Console.ReadLine();
            int id = take_Book_Id(books, name);
            books.RemoveAt(id);
        }
        public void UpdateBook(List<Book> books)
        {
            Console.WriteLine("-----------------");
            Console.Write("Book name for update: ");
            string name = Console.ReadLine();
            int id = take_Book_Id(books, name);
            Console.Write("Input book name: ");
            books[id].BookName = Console.ReadLine();
            Console.Write("Input book type: ");
            books[id].BookType = Console.ReadLine();
            Console.Write("Input number in library: ");
            books[id].Number = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowListOrder()
        {
            foreach (var o in Orders)
            {
                Console.WriteLine("-----------------");
                if(o.Type == "teacher")
                {
                    o.Show_for_Teacher();
                }
                else
                {
                    o.Show_for_Student();
                }
            }
        }
        public void ShowListStudent()
        {
            foreach (var s in Students)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine(s.ToString());
            }
        }
        public void ShowListTeacher()
        {
            foreach (var t in Teachers)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine(t.ToString());
            }
        }
    }
}
