using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Program
    {
        static void add_Book(List<Book> books)
        {
            Console.Write("Input number of book: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                int id = books.Count() + 1;
                Console.Write("Input book name: ");
                string name = Console.ReadLine();
                Console.Write("Input book type: ");
                string type = Console.ReadLine();
                Console.Write("Input number in library: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Book book = new Book(id, type, name, n);
                books.Add(book);
            }
        }

        static void add_Student(List<Student> students)
        {
            Console.WriteLine("-----------------");
            Console.Write("Input number of student: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                int id = students.Count() + 1;
                Console.Write("Input student name: ");
                string name = Console.ReadLine();
                Console.Write("Input age of student: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input student address: ");
                string address = Console.ReadLine();
                Console.Write("Input student class: ");
                string class_number = Console.ReadLine();
                Student student = new Student(id,name,age,address,class_number);
                students.Add(student);
            }
        }
        
        static void add_Teacher(List<Teacher> teachers)
        {
            Console.WriteLine("-----------------");
            Console.Write("Input number of teacher: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                int id = teachers.Count() + 1;
                Console.Write("Input teacher name: ");
                string name = Console.ReadLine();
                Console.Write("Input age of teacher: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input teacher address: ");
                string address = Console.ReadLine();
                Console.Write("Input teacher subject: ");
                string subject = Console.ReadLine();
                Teacher teacher = new Teacher(id,name,age,address,subject);
                teachers.Add(teacher);
            }
        }
        static void make_Order(List<Order> orders, Library library, string type)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"Book order by {type}");
            Console.Write("Input book name: ");
            string name = Console.ReadLine();
            if(library.IsBook(library.Books, name))
            {
                Console.Write("Input book number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (library.IsCount(library.Books, name, num))
                {
                    if(type == "teacher")
                    {
                        int id = library.take_Book_Id(library.Books, name);
                        Console.Write("Input teacher id: ");
                        int tc_id = Convert.ToInt32(Console.ReadLine());
                        Order order = new Order(library.Teachers[tc_id], library.Books[id], num);
                        orders.Add(order);
                    }
                    else
                    {
                        int id = library.take_Book_Id(library.Books, name);
                        Console.Write("Input student id: ");
                        int st_id = Convert.ToInt32(Console.ReadLine());
                        Order order = new Order(library.Students[st_id], library.Books[id], num);
                        orders.Add(order);
                    }
                }
                else
                {
                    Console.WriteLine("Dont have enough book");
                }
            }
            else
            {
                Console.WriteLine("Dont have this book in library");
            }
        }
        static void Main(string[] args)
        {
            Library library = new Library("Greenwich library");
            Console.WriteLine($"Welcom to {library.Library_Name} System");
            add_Book(library.Books);
            library.ShowListBook();
            //library.DeleteBook(library.Books);
            //library.ShowListBook();
            //library.UpdateBook(library.Books);
            //library.ShowListBook();
            //add_Student(library.Students);
            //library.ShowListStudent();
            add_Teacher(library.Teachers);
            library.ShowListTeacher();
            make_Order(library.Orders, library, "teacher");
            //make_Order(library.Orders, library, "student"); 
            library.ShowListOrder();
            Console.ReadKey();
        }
    }
}
