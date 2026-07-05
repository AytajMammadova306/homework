using System.Transactions;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sale
            //int price;
            //do
            //{
            //    Console.WriteLine("Price:");
            //    string priceStr = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(priceStr, out price);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int sale;
            //do
            //{
            //    Console.WriteLine("Sale:");
            //    string saleStr = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(saleStr, out sale);
            //    if (!result|| sale>=100 ||sale<=0)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //Console.WriteLine($"Saled price: {price*sale/100}");
            //Console.WriteLine($"need to pay: {price-price*sale/100}"); 
            #endregion

            #region salary
            //int salary;
            //do
            //{
            //    Console.WriteLine("Salary:");
            //    string salaryStr = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(salaryStr, out salary);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int extra;
            //do
            //{
            //    Console.WriteLine("Hours:");
            //    string extraStr = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(extraStr, out extra);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int hourly = salary / 160;
            //double extraPayment = hourly*1.5 * extra;
            //double total = salary + extraPayment;
            //Console.WriteLine($"Payment per hour: {hourly}");
            //Console.WriteLine($"Overtime payment: {extraPayment}");
            //Console.WriteLine($"Total peyment: {total}"); 
            #endregion


            #region temperature
            //int temp;
            //do
            //{
            //    Console.WriteLine("Celsius:");
            //    string tempStr = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(tempStr, out temp);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //Console.WriteLine($"Fahrenheit: {temp*9/5+32}");
            //int mod = temp * 10 % 10;
            //if (mod % 2 == 0) Console.WriteLine("even");
            //else Console.WriteLine("odd"); 
            #endregion


            #region leapYear
            //do
            //{
            //    int year;
            //    do
            //    {
            //        Console.WriteLine("year:");
            //        string yearStr = Console.ReadLine();
            //        Console.Clear();
            //        bool result = int.TryParse(yearStr, out year);
            //        if (!result)
            //        {
            //            Console.WriteLine("wrong entry");
            //            bool again = TryAgain();
            //            if (!again) return;
            //        }
            //        else break;
            //    } while (true);
            //    if (year % 4 == 0)
            //    {
            //        if ((year % 100 == 0 && year % 400 == 0) || year % 100 != 0)
            //            Console.WriteLine("uzun");
            //        else Console.WriteLine("qisa");
            //    }
            //    else
            //        Console.WriteLine("qisa");
            //    bool loop = TryAgain();
            //    if (!loop) return;
            //} while (true); 
            #endregion

            int count;
            do
            {
                Console.WriteLine("Numbers of students:");
                string countStr = Console.ReadLine();
                Console.Clear();
                bool result = int.TryParse(countStr, out count);
                if (!result||(result&& count==0))
                {
                    Console.WriteLine("wrong entry");
                    bool again = TryAgain();
                    if (!again) return;
                }
                else break;
            } while (true);
            string[] names = new string[count];
            int[] grades= new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter student's name: ");
                string name = Console.ReadLine();
                names[i] = name;
                int grade;
                do
                {
                    Console.Write("Enter student's grade: ");
                    string gradeStr = Console.ReadLine();
                    Console.Clear();
                    bool result = int.TryParse(gradeStr, out grade);
                    if (!result||(result&& grade<0)||(result&& grade>100))
                    {
                        Console.WriteLine("wrong entry");
                        bool again = TryAgain();
                        if (!again) return;
                    }
                    else break;
                } while (true);
                grades[i] = grade;
            }

            do
            {
                Console.WriteLine("1.Butun telebeleri goster" +
                    "\n2.Orta bali goster" +
                    "\n3.En yuksek bali goster" +
                    "\n4.En asagi bali goster" +
                    "\n5.Keçen telebeleri goster" +
                    "\n6.Kesilen telebeleri goster" +
                    "\n7.Ada gore telebe axtar" +
                    "\n8.Çixiş\n");
                int answer;
                Console.Write("Choice:");
                string answerStr = Console.ReadLine();
                Console.Clear();
                bool result = int.TryParse(answerStr, out answer);
                if (!result)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a number only");
                    Console.ResetColor();
                    continue;
                }
                int index;
                switch (answer)
                {
                    case 1:
                        ShowAll(grades,names);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Average: {Average(grades)}");
                        Console.ResetColor();
                        break;
                    case 3:
                        index = MaxGrade(grades);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"En yuksek balli telebe:\t{names[index]} - {grades[index]}");
                        Console.ResetColor();
                        break;
                    case 4:
                        index = MinGrade(grades);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"En asagi balli telebe:\t{names[index]} - {grades[index]}");
                        Console.ResetColor();
                        break;
                    case 5:
                        ShowPassed(grades,names);
                        break;
                    case 6:
                        ShowFailed(grades,names);
                        break;
                    case 7:
                        index = SearchStudent(names);
                        if (index >= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Student {names[index]} got {grades[index]}");
                            Console.ResetColor();
                        }
                        break;
                    case 8:
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.WriteLine("Have a nice day!");
                        Console.ResetColor();
                        return;
                    default:
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("There is no such option in menu");
                        Console.ResetColor();
                        break;
                }
            } while(true);

        }
        public static int SearchStudent(string[] names)
        {
            Console.Write("Enter name please: ");
            string name=Console.ReadLine();
            for(int i=0; i<names.Length; i++)
            {
                if (names[i]==name) return i;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There is no informatio about such student");
            Console.ResetColor();
            return -1;
        }
        public static void ShowPassed(int[] grades, string[]names)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Name\t\tGrade");
            Console.ResetColor();
            double average=Average(grades);
            for(int i=0;i<grades.Length;i++)
            {
                if (grades[i] > average)
                {
                    Console.WriteLine($"{names[i]}\t\t{grades[i]}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nPress any key to go back to menu");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public static void ShowFailed(int[] grades, string[]names)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Name\t\tGrade");
            Console.ResetColor();
            double average=Average(grades);
            for(int i=0;i<grades.Length;i++)
            {
                if (grades[i] <= average)
                {
                    Console.WriteLine($"{names[i]}\t\t{grades[i]}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nPress any key to go back to menu");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public static int MaxGrade(int[] grades)
        {
            int max = grades[0];
            int index = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (max < grades[i])
                {
                    max = grades[i];
                    index = i;
                }
            }
            return index;
        }
        public static int MinGrade(int[] grades)
        {
            int min = grades[0];
            int index = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (min > grades[i])
                {
                    min = grades[i];
                    index = i;
                }
            }
            return index;
        }
        public static double Average(int[]grades)
        {
            int sum = 0;
            foreach(int i in grades)
            {
                sum += i;
            }
            return (double)sum / grades.Length;
        }
        public static void ShowAll(int[] grades, string[] names)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Name\t\tGrade");
            Console.ResetColor();
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}\t\t{grades[i]}");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nPress any key to go back to menu");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public static bool TryAgain()
        {
            Console.WriteLine("would you like to try again?(Y/N)");
            do
            {
                string answer= Console.ReadLine();
                Console.Clear();
                if (answer.ToUpper() == "Y")
                {
                    return true;
                }else if (answer.ToUpper() == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("only Y or N");
                }
            } while (true);
        }

    }
}
