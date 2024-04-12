using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace PUPSISModel
{
    public class Student
    {
        public string name;
        public string section;
        public string studentNumber;
        public string password;
        public Grade grade;
        public List<Schedule> schedule;
        public Fee fee;
    }
}
