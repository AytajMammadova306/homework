using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLogAnalyse.Services
{
    internal class LogService
    {
        public const string _path = "../../../Data/app-log.txt";
        public const string _report= "../../../Data/report.txt";
        public const string _error= "../../../Data/error.txt";

        public LogService()
        {
            var directoryPath = Path.GetDirectoryName(_path);
            if (!File.Exists(_path))
            {
                Console.WriteLine("File Dosent Exist");
            }
            ReportFile();
            ErrorFile();
        }
        public void ReportFile()
        {
            var directoryReport = Path.GetDirectoryName(_report);
            if (!Directory.Exists(directoryReport))
            {
                Directory.CreateDirectory(directoryReport);
            }
            if (!File.Exists(_report))
            {
                File.WriteAllLines(_report,
                    ["LOG REPORT",
                    $"Total: {AllCount()}",
                    $"Info: {InfoCount()}",
                    $"Error: {ErrorCount()}",
                    $"Warning: {WarningCount()}"
                ]);
            }
        }
        public int AllCount()
        {
            var logs = File
                .ReadAllLines(_path)
                .Select(log => log.Split("|"));
            return logs.Count();
        }
        public int InfoCount()
        {
            var infos = File
               .ReadAllLines(_path)
               .Select(log => log.Split("|"))
               .Where(log => log[1].ToUpper()=="INFO");
            return infos.Count();
        }
        public int ErrorCount()
        {
            var errors = File
               .ReadAllLines(_path)
               .Select(log => log.Split("|"))
               .Where(log => log[1].ToUpper() == "ERROR");
            return errors.Count();
        }
        public int WarningCount()
        {
            var warnings = File
               .ReadAllLines(_path)
               .Select(log => log.Split("|"))
               .Where(log => log[1].ToUpper() == "WARNING");
            return warnings.Count();
        }
        public void ErrorFile()
        {
            var errors = File
              .ReadAllLines(_path)
              .Where(log => log.Split("|")[1].ToUpper() == "ERROR");
            var directoryError = Path.GetDirectoryName(_error);
            if (!Directory.Exists(directoryError))
            {
                Directory.CreateDirectory(directoryError);
            }
            if (!File.Exists(_error))
            {
                File.WriteAllLines(_error, errors);
            }

        }
        public void FindLog()
        {
            Console.Write("Please enter the word you would like to make a search for:");
            string str = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Entry is wrong.");
                return;
            }
            var logs = File
                .ReadAllLines(_path)
                .Select(log => log.Split("|"))
                .Where(log => log[2].ToUpper().Contains(str.ToUpper()));
            if (logs.Count() == 0)
            {
                Console.WriteLine("No Logs containing such entry");
            }
            foreach (var log in logs)
            {
                Console.WriteLine($"Date: {log[0]}, Log Name: {log[1]}, Message: {log[2]}");
            }
        }
        public void GetReport()
        {
            var logs = File
                .ReadAllLines(_report)
                .ToList();
            Console.WriteLine(logs[0]);
            logs.RemoveAt(0);
            foreach (var log in logs)
            {
                Console.WriteLine(log);
            }
        }
        public void GetErrors()
        {
            var errors = File
                .ReadAllLines(_error)
                .ToList();
            foreach (var error in errors)
            {
                var splited = error.Split('|');
                Console.WriteLine($"Date: {splited[0]}, Log Name: {splited[1]}, Message: {splited[2]}");
            }
        }
    }
}
