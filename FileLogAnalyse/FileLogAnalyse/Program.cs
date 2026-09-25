using FileLogAnalyse.Services;

namespace FileLogAnalyse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogService logService = new LogService();
            do
            {
                Console.WriteLine(
                    "1. Get Log Information" +
                    "\n2. Get Errors" +
                    "\n3. Search with word" +
                    "\n0. Exit");
                string str = Console.ReadLine();
                Console.Clear();
                switch (str)
                {
                    case "1":
                        logService.GetReport();
                        break;
                    case "2":
                        logService.GetErrors();
                        break;
                    case "3":
                        logService.FindLog();
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
