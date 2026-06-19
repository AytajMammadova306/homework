namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Login
            //string ogEmail = "aytac@gmail.com";
            //string ogPassword = "Salam123";
            //do
            //{
            //    Console.WriteLine("Enter your email please:");
            //    string email = Console.ReadLine();
            //    Console.Clear();
            //    if (email != ogEmail)
            //    {
            //        Console.WriteLine("Wrong email!");
            //        do
            //        {
            //            Console.WriteLine("Would you like to try again?(Y/N)");
            //            string answer = Console.ReadLine();
            //            Console.Clear();
            //            if (answer.ToUpper() == "Y")
            //            {
            //                break;
            //            }
            //            else if (answer.ToUpper() == "N")
            //            {
            //                return;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Type either Y or N please");
            //            }
            //        } while (true);
            //    }
            //    else break;
            //} while (true);
            //do
            //{
            //    Console.WriteLine("Please enter your password:");
            //    string password = Console.ReadLine();
            //    Console.Clear();
            //    if (password != ogPassword)
            //    {
            //        Console.WriteLine("Wrong password!");
            //        do
            //        {
            //            Console.WriteLine("Would you like to try again?(Y/N)");
            //            string answer = Console.ReadLine();
            //            Console.Clear();
            //            if (answer.ToUpper() == "Y")
            //            {
            //                break;
            //            }
            //            else if (answer.ToUpper() == "N")
            //            {
            //                return;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Type either Y or N please");
            //            }
            //        } while (true);
            //    }
            //    else break;
            //} while (true);
            //Console.Beep();
            //Console.WriteLine("Welcome!");
            //return; 
            #endregion



            #region calc
            do
            {
                double num1;
                do
                {
                    Console.WriteLine("Please enter your FIRST number:");
                    string str1 = Console.ReadLine();
                    Console.Clear();
                    bool result = double.TryParse(str1, out num1);
                    if (!result)
                    {
                        Console.WriteLine("That is NOT a number!");
                        do
                        {
                            Console.WriteLine("Would you like to try again?(Y/N)");

                            string answer1 = Console.ReadLine();
                            if (answer1.ToUpper() == "Y")
                            {
                                Console.Clear();
                                break;
                            }
                            else if (answer1.ToUpper() == "N")
                            {
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Type either Y or N please");
                            }
                        } while (true);
                    }
                    else break;
                } while (true);
                string op;
                do
                {
                    Console.WriteLine("Please enter your operaation:");
                    Console.WriteLine("+\t-\t*\t/\t!\t^\t");
                    op = Console.ReadLine();
                    Console.Clear();
                    if (op != "*" && op != "+" && op != "-" && op != "/" && op != "!"&& op!="^")
                    {
                        Console.WriteLine("Wrong operation");
                        do
                        {
                            Console.WriteLine("Would you like to try again?(Y/N)");
                            string answer2 = Console.ReadLine();
                            Console.Clear();
                            if (answer2.ToUpper() == "Y")
                            {
                                Console.Clear();
                                break;
                            }
                            else if (answer2.ToUpper() == "N")
                            {
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Type either Y or N please");
                            }


                        } while (true);
                    }
                    else break;
                } while (true);
                double num2;
                do
                {
                    if (op == "!")
                    {
                        num2 = num1;
                        break;
                    }
                    Console.WriteLine("Now please enter your SECOND number:");
                    string str2 = Console.ReadLine();
                    Console.Clear();
                    bool result = double.TryParse(str2, out num2);
                    if (!result)
                    {
                        Console.WriteLine("That is NOT a number!");
                        do
                        {
                            Console.WriteLine("Would you like to try again?(Y/N)");
                            string answer3 = Console.ReadLine();
                            Console.Clear();
                            if (answer3.ToUpper() == "Y")
                            {
                                Console.Clear();
                                break;
                            }
                            else if (answer3.ToUpper() == "N")
                            {
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("NAAAAHHHH type either Y or N");
                            }
                        } while (true);
                    }
                    else if (op == "/" && num2 == 0)
                    {
                        Console.WriteLine("Unfortunately devision by 0 is not possible");
                        do  //tekrari qisalmaq olardi yaqinki, but who cares
                        {
                            Console.WriteLine("Would you like to try again?(Y/N)");
                            string answer3 = Console.ReadLine();
                            Console.Clear();
                            if (answer3.ToUpper() == "Y")
                            {
                                Console.Clear();
                                break;
                            }
                            else if (answer3.ToUpper() == "N")
                            {
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("NAAAAHHHH type either Y or N");
                            }
                        } while (true);
                    }
                    else break;
                } while (true);
                double? answer = 0;
                switch (op)
                {
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    case "/":
                        answer = num1 / num2;
                        break;
                    case "!":
                        answer = Fact(num1);
                        if (answer is null) Console.WriteLine("for negative numbers there is no factorial");
                        break;
                    case "^":
                        answer = Pow(num1, num2);
                        if(answer is null) Console.WriteLine("our calc dosent support fraction as power");
                        break;
                }
                Console.Beep();
                if (op != "!") Console.WriteLine(num1 + op + num2 + "=" + answer);
                else if (op == "!" && answer is not null) Console.WriteLine(num1 + "=" + answer);
                do
                {
                    Console.WriteLine("Would you calculate something again?(Y/N)");
                    string answer4 = Console.ReadLine();
                    Console.Clear();
                    if (answer4.ToUpper() == "Y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (answer4.ToUpper() == "N")
                    {
                        Console.WriteLine("Have a nice day!");
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("type either Y or N");
                    }
                } while (true);

            } while (true);
            #endregion





        }
        public static double? Fact(double a)
        {
            double num = a;
            if (a < 0) return null;
            else if (a == 0) return 1;
            for (int i = 1; i < a; i++)
            {
                num *= i;
            }
            return num;
        }
        public static double? Pow(double num, double pow)
        {
            double answer = 1;
            if (pow == 0) return 1;
            if ((pow*10)%10!=0) return null;
            if (pow < 0) pow *= (-1);
            for (int i = 0; i < pow; i++) answer *= num;
            return answer;
            
        }
    }
}
