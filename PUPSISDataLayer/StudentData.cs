using System;
using System.Collections.Generic;
using System.Diagnostics;
using PUPSISModel;
namespace PUPSISDataLayer
{
    public class StudentData
    {
        public ScheduleData scheduleData = new ScheduleData();

        public List<Student> students = new List<Student>();
        public StudentData()
        {
            RegisteredStudentData();
        }

        public void RegisteredStudentData()
        {
            Fee fee = new Fee { balance = 2000, category = "Balanced Fee" };

            Grade grade1 = new Grade { subject1 = "PATHFIT1: ", score1 = 1.00, subject2 = "CompProg1: ", score2 = 1.25, subject3 = "Discrete Structures: ", score3 = 1.25 };
            Student student1 = new Student { name = "Charles Potazo", section = "BSIT 2-1", studentNumber = "2020-0001", password = "Hello", grade = grade1, schedule = scheduleData.getBSIT2Schedule(), fee = fee };
            students.Add(student1);

            Grade grade2 = new Grade { subject1 = "PATHFIT1: ", score1 = 1.00, subject2 = "CompProg 1: ", score2 = 1.00, subject3 = "Discrete Structures: ", score3 = 1.50 };
            Student student2 = new Student { name = "Marc Tenido", section = "BSIT 2-1", studentNumber = "2020-0002", password = "Love", grade = grade2, schedule = scheduleData.getBSIT2Schedule(), fee = fee };
            students.Add(student2);

            Grade grade3 = new Grade { subject1 = "PATHFIT3: ", score1 = 1.00, subject2 = "Operating Systems: ", score2 = 1.00, subject3 = "RVA: ", score3 = 1.75 };
            Student student3 = new Student { name = "Prince Salvador", section = "BSIT 3-1", studentNumber = "2019-0001", password = "HAHA", grade = grade3, schedule = scheduleData.getBSIT3Schedule(), fee = fee };
            students.Add(student3);

            Grade grade4 = new Grade { subject1 = "PATHFIT3: ", score1 = 1.00, subject2 = "Operating Systems: ", score2 = 1.25, subject3 = "RVA: ", score3 = 1.75 };
            Student student4 = new Student { name = "Chino Bote", section = "BSIT 3-1", studentNumber = "2019-0002", password = "Huhu", grade = grade4, schedule = scheduleData.getBSIT3Schedule(), fee = fee };
            students.Add(student4);
        }

        public Student GetStudentDL(string studentNumber, string password)
        {
            Student foundStudent = new Student();
            foreach (Student student in students)
            {
                if (studentNumber == student.studentNumber && password == student.password)
                {
                    foundStudent = student;
                }
            }
            return foundStudent;
        }

        public Student GetStudentDL(string studentNumber)
        {
            foreach (Student student in students)
            {
                if (student.studentNumber == studentNumber)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
