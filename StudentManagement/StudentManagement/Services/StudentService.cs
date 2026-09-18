using StudentManagement.Modul;
using StudentManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    internal class StudentService
    {
        public const string _path = "../../../Data/Students.txt";
        public StudentService()
        {
            var directoryPath = Path.GetDirectoryName(_path);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(_path))
            {
                File.WriteAllText(_path,"");
            }
        }
        public void AddStudent()
        {
            Console.Write("Please enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter Surname: ");
            string surname= Console.ReadLine();
            int grade;
            do
            {
                Console.Write("Please enter Grade:");
                string str= Console.ReadLine();
                Console.Clear();
                if (!int.TryParse(str, out grade))
                {
                    Console.WriteLine("Wrong entry");
                    bool loop = Extentions.TryAgain();
                    if (!loop) return;
                }
                else break;
            } while (true);
            Student student= new Student(name, surname, grade);
            File.AppendAllText(_path, student.ToString()+"\n");
        }

        public void FindStudent()
        {
            int id;
            do
            {
                Console.Write("Please enter Id:");
                string str = Console.ReadLine();
                Console.Clear();
                if (!int.TryParse(str, out id))
                {
                    Console.WriteLine("Wrong entry");
                    bool loop = Extentions.TryAgain();
                    if (!loop) return;
                }
                else break;
            } while (true);
            var student = File
                .ReadAllLines(_path)
                .Select(student => student.Split("|"))
                .FirstOrDefault(splitted => int.Parse(splitted[0]) == id);
            if (student != null)
            {
                Console.WriteLine($"Id: {student[0]}\nName: {student[1]}\nSurname: {student[2]}\nGrade: {student[3]}\n");
            }
            else Console.WriteLine("No such student");
        }

        public void ShowAllStudents()
        {
            var students = File
                .ReadAllLines(_path)
                .ToList();
            foreach (var student in students)
            {
                var splited= student.Split('|');
                Console.WriteLine($"Id: {splited[0]}\nName: {splited[1]}\nSurname: {splited[2]}\nGrade: {splited[3]}\n");
            }

        }
    }
}
