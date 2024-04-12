using System;
using PUPSISModel;
using PUPSISBusinessLogic;

namespace PUPSISUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentBL studentService = new StudentBL();

            Console.WriteLine("Welcome to PUP Online Transaction");
            Console.WriteLine("\nEnter Student Number:  ");
            String studentNumber = Console.ReadLine();
            Console.WriteLine("\nEnter Password:  ");
            String password = Console.ReadLine();

            bool result = studentService.VerifyStudent(studentNumber, password);
            Student foundStudent = studentService.GetStudentBL(studentNumber);

            if (result)
            {
                Console.WriteLine("Welcome " + foundStudent.name + " " + foundStudent.section);
                DisplayMenu(studentNumber);
            }
            else
            {
                Console.WriteLine("Error Try Again");
                Main(args);
            }
        }
        public static void DisplayMenu(string studentNumber)
        {
            StudentBL studentService = new StudentBL();
            Console.WriteLine("\nChoose a Number: ");
            Console.WriteLine("1.Schedule\n2.Grades\n3.Pending Fee\n4.Log Out");
            byte choice = Convert.ToByte(Console.ReadLine());
            Student foundStudent = studentService.GetStudentBL(studentNumber);

            switch (choice)
            {
                case 1:
                    foreach (Schedule sched in foundStudent.schedule)
                    {

                        Console.WriteLine("Subject: " + sched.subject + ", Room: " + sched.room + ", DateTime: "+sched.dateTime);
                    }
                    DisplayMenu(studentNumber);
                    break;
                case 2:
                    Console.WriteLine(foundStudent.grade.subject1 + " " + foundStudent.grade.score1 + "\n" + foundStudent.grade.subject2 + " " + foundStudent.grade.score2 + "\n" + foundStudent.grade.subject3 + " " + foundStudent.grade.score3);
                    DisplayMenu(studentNumber);
                    break;
                case 3:
                    Console.WriteLine("Your " + foundStudent.fee.category + " " + foundStudent.fee.balance);
                    DisplayMenu(studentNumber);
                    break;
                case 4:
                    Console.WriteLine("Are You Sure: [Yes/No]");
                    string answer = Convert.ToString(Console.ReadLine());

                    if (answer.ToLower() != "yes")
                    {
                        DisplayMenu(studentNumber);
                    }
                    else if (answer.ToLower() != "no")
                    {
                        Console.WriteLine("Thank you for using the app");
                    }
                    else
                    {
                        Console.WriteLine("I cannot understand what you input.Please choose again");
                        DisplayMenu(studentNumber);
                    }
                    break;
                default:
                    Console.WriteLine("I cannot understand what you input.Please choose again");
                    DisplayMenu(studentNumber);
                    break;
            }
        }
    }
}
