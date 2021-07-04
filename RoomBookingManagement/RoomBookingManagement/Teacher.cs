using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Teacher: Person
    {
        public int TeacherID { get; set; }
        public string Subject { get; set; }

        public Teacher(int teacherID, string name, int age, string address, string subject)
        {
            TeacherID = teacherID;
            Name = name;
            Age = age;
            Address = address;
            Subject = subject;
        }
        public override string ToString()
        {
            return $"ID = {TeacherID}, " +
                $" Teacher Name = {Name}, Age = {Age}, Address = {Address}, Subject = {Subject}";
        }
    }
}
