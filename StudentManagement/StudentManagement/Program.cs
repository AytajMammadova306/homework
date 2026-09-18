using StudentManagement.Services;
using StudentManagement.Utilities;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            do
            {
                Console.WriteLine(
                    "1. Add Student" +
                    "\n2. Show All Students" +
                    "\n3. Find Student" +
                    "\n0. Exit");
                string str= Console.ReadLine();
                Console.Clear();
                switch (str)
                {
                    case "1":
                        studentService.AddStudent();
                        break;
                    case "2":
                        studentService.ShowAllStudents();
                        break;
                    case "3":
                        studentService.FindStudent();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (true);
        }
    }
}
