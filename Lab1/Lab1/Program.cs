using Microsoft.VisualBasic;
using System.Text;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region temp
            //int temp;
            //do
            //{
            //    Console.WriteLine("Enter your temp:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out temp);
            //    if (!result)
            //    {
            //        Console.WriteLine("it should be number");
            //        do
            //        {
            //            Console.WriteLine("Would you like to try again?(Y/N)");
            //            string answer = Console.ReadLine();
            //            Console.Clear();
            //            if (answer.ToUpper() == "Y") break;
            //            else if (answer.ToUpper() == "N") return;
            //            else Console.WriteLine("that should be Y or N");
            //        } while (true);
            //    }
            //    else break;
            //}while (true);
            //switch (temp)
            //{
            //    case <0:
            //        Console.WriteLine("Freezing");
            //        break;
            //    case >0 and <15:
            //            Console.WriteLine("Cold");
            //        break;
            //    case >15 and <25:
            //            Console.WriteLine("Moderate");
            //        break;
            //    default:
            //        Console.WriteLine("Hot");
            //        break;
            //} 
            #endregion



            #region char finder
            //char ch;
            //do
            //{
            //    Console.WriteLine("enter your char");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result=char.TryParse(str, out ch);
            //    if (!result)
            //    {
            //        Console.WriteLine("enter 1 character");
            //        do
            //        {
            //            Console.WriteLine("Would you like to try again?(Y/N)");
            //            string answer = Console.ReadLine();
            //            Console.Clear();
            //            if (answer.ToUpper() == "Y") break;
            //            else if (answer.ToUpper() == "N") return;
            //            else Console.WriteLine("that should be Y or N");
            //        } while (true);
            //    }
            //    else break;
            //} while (true);
            //switch ((int)ch)
            //{
            //    case >= 48 and <= 57:
            //        Console.WriteLine("digit");
            //        break;
            //    case >= 65 and <= 90:
            //        Console.WriteLine("Upper case");
            //        break;
            //    case >= 97 and <= 122:
            //        Console.WriteLine("Lower case");
            //        break;
            //    default:
            //        Console.WriteLine("special sign");
            //        break;
            //} 
            #endregion

            #region divisibilaty
            //int num1;
            //do
            //{
            //    Console.WriteLine("enter FIRST number");
            //    bool result = int.TryParse(Console.ReadLine(), out num1);
            //    Console.Clear();
            //    if (!result)
            //    {
            //        do
            //        {
            //            Console.WriteLine("Would you like to try again?(Y/N)");
            //            string answer = Console.ReadLine();
            //            Console.Clear();
            //            if (answer.ToUpper() == "Y") break;
            //            else if (answer.ToUpper() == "N") return;
            //            else Console.WriteLine("that should be Y or N");
            //        } while (true);
            //    }
            //    else break;
            //} while (true);
            //int num2;
            //do
            //{
            //    Console.WriteLine("enter SECOND number");
            //    bool result = int.TryParse(Console.ReadLine(), out num2);
            //    Console.Clear();
            //    if (!result)
            //    {
            //        do
            //        {
            //            Console.WriteLine("Would you like to try again?(Y/N)");
            //            string answer = Console.ReadLine();
            //            Console.Clear();
            //            if (answer.ToUpper() == "Y") break;
            //            else if (answer.ToUpper() == "N") return;
            //            else Console.WriteLine("that should be Y or N");
            //        } while (true);
            //    }
            //    else break;
            //} while (true);
            //if (num2 == 0)
            //{
            //    Console.WriteLine("we dont devide by 0");
            //    return;
            //}
            //if (num1 % num2 == 0) Console.WriteLine("Divisible");
            //else Console.WriteLine("not divisible"); 
            #endregion

            #region FizzBuzz
            //do
            //{
            //    int num;
            //    do
            //    {
            //        Console.WriteLine("enter your number");
            //        bool result = int.TryParse(Console.ReadLine(), out num);
            //        Console.Clear();
            //        if (!result)
            //        {
            //            do
            //            {
            //                Console.WriteLine("Would you like to try again?(Y/N)");
            //                string answer = Console.ReadLine();
            //                Console.Clear();
            //                if (answer.ToUpper() == "Y") break;
            //                else if (answer.ToUpper() == "N") return;
            //                else Console.WriteLine("that should be Y or N");
            //            } while (true);
            //        }
            //        else break;
            //    } while (true);
            //    if (num % 5 == 0 && num % 3 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (num % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else if (num % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    do
            //    {
            //        Console.WriteLine("Would you like to try again?(Y/N)");
            //        string answer = Console.ReadLine();
            //        Console.Clear();
            //        if (answer.ToUpper() == "Y") break;
            //        else if (answer.ToUpper() == "N") return;
            //        else Console.WriteLine("that should be Y or N");
            //    } while (true);
            //} while (true); 
            #endregion

            #region end is 7
            //do
            //{
            //    int num;
            //    do
            //    {
            //        Console.WriteLine("enter your number");
            //        bool result = int.TryParse(Console.ReadLine(), out num);
            //        Console.Clear();
            //        if (!result)
            //        {
            //            do
            //            {
            //                Console.WriteLine("Would you like to try again?(Y/N)");
            //                string answer = Console.ReadLine();
            //                Console.Clear();
            //                if (answer.ToUpper() == "Y") break;
            //                else if (answer.ToUpper() == "N") return;
            //                else Console.WriteLine("that should be Y or N");
            //            } while (true);
            //        }
            //        else break;
            //    } while (true);
            //    if (num % 10 == 7) Console.WriteLine("Special number");
            //    else Console.WriteLine("ordinary");
            //    do
            //    {
            //        Console.WriteLine("Would you like to try again?(Y/N)");
            //        string answer = Console.ReadLine();
            //        Console.Clear();
            //        if (answer.ToUpper() == "Y") break;
            //        else if (answer.ToUpper() == "N") return;
            //        else Console.WriteLine("that should be Y or N");
            //    } while (true);
            //} while (true); 
            #endregion

            #region Ticket
            //do
            //{
            //    int num;
            //    do
            //    {
            //        Console.WriteLine("enter your number");
            //        bool result = int.TryParse(Console.ReadLine(), out num);
            //        Console.Clear();
            //        if (!result)
            //        {
            //            do
            //            {
            //                Console.WriteLine("Would you like to try again?(Y/N)");
            //                string answer = Console.ReadLine();
            //                Console.Clear();
            //                if (answer.ToUpper() == "Y") break;
            //                else if (answer.ToUpper() == "N") return;
            //                else Console.WriteLine("that should be Y or N");
            //            } while (true);
            //        }
            //        else break;
            //    } while (true);
            //    bool weekend;
            //    do
            //    {
            //        Console.WriteLine("is it weekend?");
            //        bool result = bool.TryParse(Console.ReadLine(), out weekend);
            //        Console.Clear();
            //        if (!result)
            //        {
            //            Console.WriteLine("should be true or false");
            //            do
            //            {
            //                Console.WriteLine("Would you like to try again?(Y/N)");
            //                string answer = Console.ReadLine();
            //                Console.Clear();
            //                if (answer.ToUpper() == "Y") break;
            //                else if (answer.ToUpper() == "N") return;
            //                else Console.WriteLine("that should be Y or N");
            //            } while (true);
            //        }
            //        else break;
            //    } while (true);
            //    double total=0;
            //    switch (num)
            //    {
            //        case >= 0 and <= 3:
            //            Console.WriteLine("free");
            //            break;
            //        case >= 4 and <= 12:
            //            total = 10;
            //            break;
            //        case >= 13 and <= 64:
            //            total = 20;
            //            break;
            //        case >= 65:
            //            total = 15;
            //            break;
            //    }
            //    if(total!=0 && weekend)
            //    {
            //        total += total * 0.5;
            //        Console.WriteLine(total);
            //    }
            //    do
            //    {
            //        Console.WriteLine("Would you like to chaeck in again?(Y/N)");
            //        string answer = Console.ReadLine();
            //        Console.Clear();
            //        if (answer.ToUpper() == "Y") break;
            //        else if (answer.ToUpper() == "N") return;
            //        else Console.WriteLine("that should be Y or N");
            //    } while (true);
            //} while (true);
            #endregion

            #region summer
            //int sum = 0;
            //int num;
            //do
            //{
            //    do
            //    {
            //        Console.WriteLine("sum: "+sum);
            //        Console.WriteLine("enter your number");
            //        bool result = int.TryParse(Console.ReadLine(), out num);
            //        Console.Clear();
            //        if (!result)
            //        {
            //            do
            //            {
            //                Console.WriteLine("Would you like to try again?(Y/N)");
            //                string answer = Console.ReadLine();
            //                Console.Clear();
            //                if (answer.ToUpper() == "Y") break;
            //                else if (answer.ToUpper() == "N") return;
            //                else Console.WriteLine("that should be Y or N");
            //            } while (true);
            //        }
            //        else break;
            //    } while (true);
            //    sum += num;
            //} while (num!=0);
            //Console.WriteLine(sum); 
            #endregion


            //21 bolunene. 1 line???????
            //for (int i = 21; i < 1000; i += 21) Console.WriteLine(i);

            //obirilere hesev yoxdu, daha basicdi


            #region polidrom
            //do
            //{
            //    Console.WriteLine("enter your number");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    if (str.Equals(Reverse(str))) Console.WriteLine("polidrom");
            //    else Console.WriteLine("not polidrom");
            //    do
            //    {
            //        Console.WriteLine("Would you like to try again?(Y/N)");
            //        string answer = Console.ReadLine();
            //        Console.Clear();
            //        if (answer.ToUpper() == "Y") break;
            //        else if (answer.ToUpper() == "N") return;
            //        else Console.WriteLine("that should be Y or N");
            //    } while (true);
            //} while (true); 
            #endregion


        }
        public static string Reverse(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
