using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Order
    {
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public string Type { get; set; }
        public Book Book { get; set; }
        public int Number { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Order(Student student, Book book, int num)
        {
            Type = "student";
            Student = student;
            Book = book;
            Number = num;
            StartDate = DateTime.Now;
            EndDate = DateTime.Today;
        }
        public Order(Teacher teacher, Book book, int num)
        {
            Type = "teacher";
            Teacher = teacher;
            Book = book;
            Number = num;
            StartDate = DateTime.Now;
            EndDate = DateTime.Today;
        }
        public void Show_for_Teacher()
        {
            Console.WriteLine($"Book borrow by {Type} name {Teacher.Name}");
            Console.WriteLine($"Book name : {Book.BookName}");
            Console.WriteLine($"Number borrow : {Number}");
            Console.WriteLine($"With start date and end date is : {StartDate} and {EndDate}");
        }
        public void Show_for_Student()
        {
            Console.WriteLine($"Book borrow by {Type} name {Student.Name}");
            Console.WriteLine($"Book name : {Book.BookName}");
            Console.WriteLine($"Number borrow : {Number}");
            Console.WriteLine($"With start date and end date is : {StartDate} and {EndDate}");
        }
    }
}
