using System;
using PUPSISModel;
using PUPSISDataLayer;
using System.Collections.Generic;
namespace PUPSISBusinessLogic
{
    public class StudentBL
    {
        StudentData studentData = new StudentData();
        public bool VerifyStudent(string studentNumber, string password)
        {
            Student result = studentData.GetStudentDL(studentNumber, password);

            return result.studentNumber != null ? true : false && result.password != null ? true : false;
        }

        public Student GetStudentBL(string studentNumber)
        {
            return studentData.GetStudentDL(studentNumber);
        }
    }
}
