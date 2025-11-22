using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoHuyAn_BTVN_02
{
    internal class Student
    {
        public int studentID { get; set; }
        public string fullName { get; set; }
        public int Age { get; set; }
        public Student(int studentID, string fullname, int Age) 
        {
            this.studentID = studentID;
            this.fullName = fullname;
            this.Age = Age;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Tên: {Name}, Tuổi: {Age}";
        }
    }
}
}
