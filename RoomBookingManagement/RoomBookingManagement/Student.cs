using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Student:Person
    {
        public int StudentID { get; set; }
        public string Class { get; set; }

        public Student(int studentID, string name, int age, string address, string class_number)
        {
            StudentID = studentID;
            Name = name;
            Age = age;
            Address = address;
            Class = class_number;
        }
        public override string ToString()
        {
            return $"Student ID = {StudentID}, Name = {Name}, Class = {Class}";
        }
    }
}
