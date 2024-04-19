using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using PUPSISModel;
namespace PUPSISDataLayer
{
    public class StudentData
    {
        public ScheduleData scheduleData = new ScheduleData();
        public GradesData gradesData = new GradesData();
        public FeeData feeData = new FeeData();


        public List<Student> students = new List<Student>();
        public StudentData()
        {
            RegisteredStudentData();
        }

        public void RegisteredStudentData()
        {
            Student student1 = new Student { name = "Charles Potazo", section = "BSIT 2-1", studentNumber = "2020-0001", password = "Hello", grade = gradesData.CharlesGrades(), schedule = scheduleData.getBSIT2Schedule(), fee = feeData.Fee() };
            students.Add(student1);

            Student student2 = new Student { name = "Marc Tenido", section = "BSIT 2-1", studentNumber = "2020-0002", password = "Love", grade = gradesData.MarcGrades(), schedule = scheduleData.getBSIT2Schedule(), fee = feeData.Fee() };
            students.Add(student2);

            Student student3 = new Student { name = "Prince Salvador", section = "BSIT 3-1", studentNumber = "2019-0001", password = "HAHA", grade = gradesData.PrinceGrades(), schedule = scheduleData.getBSIT3Schedule(), fee = feeData.Fee() };
            students.Add(student3);

            Student student4 = new Student { name = "Chino Bote", section = "BSIT 3-1", studentNumber = "2019-0002", password = "Huhu", grade = gradesData.ChinoGrades(), schedule = scheduleData.getBSIT3Schedule(), fee = feeData.Fee() };
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
