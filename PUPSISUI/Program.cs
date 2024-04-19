using System;
using PUPSISModel;
using PUPSISBusinessLogic;
using PUPSISDataLayer;
using System.Diagnostics;

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
            Console.WriteLine("Enter Password:  ");
            String password = Console.ReadLine();

            bool result = studentService.VerifyStudent(studentNumber, password);
            Student foundStudent = studentService.GetStudentBL(studentNumber);

            if (result)
            {
                Console.WriteLine($"\nWelcome {foundStudent.name} || Current Section: {foundStudent.section}");
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
            Console.WriteLine("\n____________________Choose a Number:____________________ \n1.Schedule  ||  2.Grades  ||  3.Pending Fee  ||  4.Log Out");
            byte choice = Convert.ToByte(Console.ReadLine());
            Student foundStudent = studentService.GetStudentBL(studentNumber);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your Second Semester Schedule");
                    foreach (Schedule sched in foundStudent.schedule)
                    {
                        Console.WriteLine($"Subject:{sched.subject}  ||Room:{sched.room}  ||Date and Time {sched.dateTime}");
                    }
                    DisplayMenu(studentNumber);
                    break;
                case 2:
                    Console.WriteLine("Your First Semester Grades");
                    foreach (Grade grade in foundStudent.grade)
                    {
                        Console.WriteLine($"Subject:{grade.subject}||  Grades:{grade.score}");
                    }
                    DisplayMenu(studentNumber);
                    break;
                case 3:
                    Console.WriteLine($"Your {foundStudent.fee.category}: {foundStudent.fee.amount}");
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
