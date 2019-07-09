using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    public interface IOOP
    {
        void StudentInfo();
    }
    public class Student
    {
        public string Name { get; set; }
        public int id { get; set; }
        public string section { get; set; }
    }
}
