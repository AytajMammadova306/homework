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


            #region Max
            //int[] arr = new int[3];
            //for(int i=0; i<3; i++)
            //{
            //    int num;
            //    do
            //    {
            //        Console.WriteLine($"number {i+1}:");
            //        string str = Console.ReadLine();
            //        Console.Clear();
            //        bool result = int.TryParse(str, out num);
            //        if (!result)
            //        {
            //            Console.WriteLine("wrong entry");
            //            bool again = TryAgain();
            //            if (!again) return;
            //        }
            //        else break;
            //    } while (true);
            //    arr[i] = num;
            //}
            //int max = arr[0];
            //foreach(int i in arr)
            //{
            //    if (max < i)
            //    {
            //        max = i;
            //    }
            //}
            //Console.WriteLine("max: "+max); 
            #endregion


            #region ucbucaq
            //int[] arr = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    int num;
            //    do
            //    {
            //        Console.WriteLine($"teref {i + 1}:");
            //        string str = Console.ReadLine();
            //        Console.Clear();
            //        bool result = int.TryParse(str, out num);
            //        if (!result)
            //        {
            //            Console.WriteLine("wrong entry");
            //            bool again = TryAgain();
            //            if (!again) return;
            //        }
            //        else break;
            //    } while (true);
            //    arr[i] = num;
            //}
            //if (arr[0] + arr[1] > arr[2] & arr[1] + arr[2] > arr[0] && arr[2] + arr[0] > arr[0])
            //{
            //    int count = 0;
            //    for(int i =0; i < arr.Length;i++)
            //    {
            //        for (int j = 0; j < arr.Length; j++)
            //        {
            //            if (i != j && arr[i] ==arr[j]) count++;
            //        }
            //    }
            //    if(count==6) Console.WriteLine("Beraberterefli");
            //    else if(count==2) Console.WriteLine("beraberyanli");
            //    else Console.WriteLine("muxtelif terefli");

            //}
            //else Console.WriteLine("that is not a triangle"); 
            #endregion

            #region grade
            //int grade;
            //do
            //{
            //    Console.WriteLine("Grade:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out grade);
            //    if (!result|| grade<0||grade >100)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //switch (grade)
            //{
            //    case <= 100 and >=90:
            //        Console.WriteLine("A");
            //        break;
            //    case <= 89 and >=75:
            //        Console.WriteLine("B");
            //        break;
            //    case <= 74 and >=60:
            //        Console.WriteLine("C");
            //        break;
            //    case <= 59 and >=45:
            //        Console.WriteLine("D");
            //        break;
            //    case < 45:
            //        Console.WriteLine("F");
            //        break;

            //} 
            #endregion


            #region calc
            //int num1;
            //do
            //{
            //    Console.WriteLine("Number 1:");
            //    string str1 = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str1, out num1);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //string op;
            //do
            //{
            //    Console.WriteLine("Enter operation:");
            //    op = Console.ReadLine();
            //    Console.Clear();
            //    if (op != "+" && op != "-" && op != "*" && op != "/")
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int num2;
            //do
            //{
            //    Console.WriteLine("Number 2:");
            //    string str2 = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str2, out num2);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else if (op == "/" && num2 == 0)
            //    {
            //        Console.WriteLine("devision by 0 is not allowed");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //double answer=default;
            //switch (op)
            //{
            //    case "+":
            //        answer = num1 + num2;
            //        break;
            //    case "-":
            //        answer = num1 - num2;
            //        break;
            //    case "*":
            //        answer = num1 * num2;
            //        break;
            //    case "/":
            //        answer = (double)num1 / num2;
            //        break;
            //}
            //Console.WriteLine(num1+op+num2+"="+answer); 
            #endregion

            #region weekdays
            //int num;
            //do
            //{
            //    Console.WriteLine("enter number of week's day:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out num);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("wrong entry");
            //        break;
            //} 
            #endregion

            #region daysofmonth
            //do
            //{
            //    int year;
            //    int feb = 0;
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
            //            feb = 29;
            //        else feb = 28;
            //    }
            //    else
            //        feb = 28;

            //    int month;
            //    do
            //    {
            //        Console.WriteLine("Month:");
            //        string monthStr = Console.ReadLine();
            //        Console.Clear();
            //        bool result = int.TryParse(monthStr, out month);
            //        if (!result || month < 0||month>12)
            //        {
            //            Console.WriteLine("wrong entry");
            //            bool again = TryAgain();
            //            if (!again) return;
            //        }
            //        else break;
            //    } while (true);
            //    switch (month)
            //    {
            //        case 1 or 3 or 5 or 7 or 8 or 10 or 12:
            //            Console.WriteLine("31 days in this month");
            //            break;
            //        case 4 or 6 or 9 or 11:
            //            Console.WriteLine("30 days in this month");
            //            break;
            //        case 2:
            //            Console.WriteLine($"{feb} days in this month");
            //            break;
            //    }
            //    bool loop = TryAgain();
            //    if (!loop) return;
            //} while (true); 
            #endregion

            #region factorial
            //int num;
            //do
            //{
            //    Console.Write("Number:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out num);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int answer = num;
            //for(int i=1; i < num; i++)
            //{
            //    answer *= i;
            //}
            //Console.WriteLine($"{num}! = {answer}"); 
            #endregion

            #region prime
            //int num;
            //do
            //{
            //    Console.WriteLine("Number:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out num);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //if (num <= 1)
            //{
            //    Console.WriteLine("neither prime nor complex");
            //    return;
            //}
            //bool isPrime = true;
            //for(int i=2;i<num;i++)
            //{
            //    if (num % i == 0) isPrime = false;
            //}
            //if (isPrime) Console.WriteLine("Prime");
            //else Console.WriteLine("Complex"); 
            #endregion

            #region digits
            //int num;
            //do
            //{
            //    Console.WriteLine("number:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out num);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int sum = 0;
            //int count = 0;
            //do
            //{
            //    sum += num % 10;
            //    num /= 10;
            //    count++;
            //} while (num !=0);
            //Console.WriteLine("sum: "+ sum);
            //Console.WriteLine("count: "+ count); 
            #endregion

            #region finabochi
            //int num;
            //do
            //{
            //    Console.WriteLine("Number of finabochi:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out num);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int sum = 0;
            //int previous = 1;
            //for(int i = 0; i < num; i++)
            //{
            //    if(i==0) Console.Write(0+" ");
            //    else
            //    {
            //        int f = sum + previous;
            //        previous = sum;
            //        sum = f;
            //        Console.Write(f+" ");
            //    }
            //} 
            #endregion


            #region piramid
            //int num;
            //do
            //{
            //    Console.Write("Number:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out num);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //for(int i = 1; i <= num; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region secondMax
            //int length;
            //do
            //{
            //    Console.Write("Length: ");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out length);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int[] arr = new int[length];
            //for(int i=0; i<arr.Length; i++)
            //{
            //    int num;
            //    do
            //    {
            //        Console.Write("Number: ");
            //        string str = Console.ReadLine();
            //        Console.Clear();
            //        bool result = int.TryParse(str, out num);
            //        if (!result)
            //        {
            //            Console.WriteLine("wrong entry");
            //            bool again = TryAgain();
            //            if (!again) return;
            //        }
            //        else break;
            //    } while (true);
            //    arr[i] = num;
            //}
            //int max;
            //int secondMax;
            //if (arr[0] > arr[1])
            //{
            //    max=arr[0];
            //    secondMax=arr[1];
            //}
            //else
            //{
            //    max = arr[1];
            //    secondMax=arr[0];
            //}
            //foreach (int i in arr)
            //{
            //    if (max < i)
            //    {
            //        secondMax = max;
            //        max = i;
            //    }
            //    else if (i > secondMax && i != max) secondMax = i;
            //}
            //Console.WriteLine(secondMax); 
            #endregion

            #region artan
            //int length;
            //do
            //{
            //    Console.Write("Length: ");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out length);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int[] arr = new int[length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int num;
            //    do
            //    {
            //        Console.Write("Number: ");
            //        string str = Console.ReadLine();
            //        Console.Clear();
            //        bool result = int.TryParse(str, out num);
            //        if (!result)
            //        {
            //            Console.WriteLine("wrong entry");
            //            bool again = TryAgain();
            //            if (!again) return;
            //        }
            //        else break;
            //    } while (true);
            //    arr[i] = num;
            //}
            //bool checker = true;
            //for(int  i = 0; i < length-1; i++)
            //{
            //    if (arr[i + 1] < arr[i]) checker=false;
            //}
            //if (checker) Console.WriteLine("artan");
            //else Console.WriteLine("artan deyil"); 
            #endregion


            #region even
            //int length;
            //int count = 0;
            //int sum = 0;
            //do
            //{
            //    Console.Write("Length: ");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out length);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int[] arr = new int[length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int num;
            //    do
            //    {
            //        Console.Write("Number: ");
            //        string str = Console.ReadLine();
            //        Console.Clear();
            //        bool result = int.TryParse(str, out num);
            //        if (!result)
            //        {
            //            Console.WriteLine("wrong entry");
            //            bool again = TryAgain();
            //            if (!again) return;
            //        }
            //        else break;
            //    } while (true);
            //    if (num % 2 == 0)
            //    {
            //        count++;
            //        sum += num;
            //    }
            //}
            //Console.WriteLine("Sum: "+sum+"\nCount: "+count); 
            #endregion

            #region negative
            //int sum = 0;
            //string s= "";
            //int length;
            //do
            //{
            //    Console.Write("Length: ");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out length);
            //    if (!result)
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int[] arr = new int[length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int num;
            //    do
            //    {
            //        Console.Write("Number: ");
            //        string str = Console.ReadLine();
            //        Console.Clear();
            //        bool result = int.TryParse(str, out num);
            //        if (!result)
            //        {
            //            Console.WriteLine("wrong entry");
            //            bool again = TryAgain();
            //            if (!again) return;
            //        }
            //        else break;
            //    } while (true);
            //    if (num < 0)
            //    {
            //        s =s+" "+i;
            //        sum += num;
            //    }
            //}
            //Console.WriteLine("index: "+s);
            //Console.WriteLine("Sum: "+sum); 
            #endregion

            #region polidrom
            //string str = Console.ReadLine();
            //int step = 0;
            //bool result = true;
            //if (str.Length % 2 != 0)
            //{
            //    step = (str.Length - 1) / 2 - 1;
            //}
            //else
            //{
            //    step = str.Length / 2 - 1;
            //}
            //for (int i = 0; i <= step; i++)
            //{
            //    if (str[i] != str[(str.Length - 1 - i)])
            //    {
            //        result = false;
            //    }
            //}
            //if (result) Console.WriteLine("is polidrom");
            //else Console.WriteLine("not polidrom"); 
            #endregion

            #region sait
            //char[] chars = { 'a','e','i','o','u'};
            //string str= Console.ReadLine();
            //int count = 0;
            //foreach(char c in str)
            //{
            //    foreach(char c2 in chars)
            //    {
            //        if (c == c2) count++;
            //    }
            //}
            //Console.WriteLine(count); 
            #endregion

            #region upperCase
            //string str = Console.ReadLine();
            //int count = 0;
            //string indexs = "";
            //for(int i=0;i<str.Length;i++) 
            //{
            //    if (str[i].ToString().Equals(str[i].ToString().ToUpper()))
            //    {
            //        count++;
            //        indexs = indexs + i + " ";
            //    }
            //}
            //Console.WriteLine("Count: "+count);
            //Console.WriteLine("Index: "+ indexs); 
            #endregion

            #region isEven
            //Console.WriteLine(IsEven(2));
            //Console.WriteLine(IsEven(3));
            //Console.WriteLine(IsEven(0));
            //Console.WriteLine(IsEven(-2)); 
            #endregion

            #region Max
            //int[] arr = { 9, 6, 2, 8, 3, -2 };
            //Console.WriteLine(Max(arr)); 
            #endregion

            #region Polidrom
            //Console.WriteLine(IsPolidrom("ses"));
            //Console.WriteLine(IsPolidrom("salam")); 
            #endregion


            #region mini console 
            //int count;
            //do
            //{
            //    Console.WriteLine("Numbers of students:");
            //    string countStr = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(countStr, out count);
            //    if (!result||(result&& count==0))
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //string[] names = new string[count];
            //int[] grades= new int[count];
            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write("Enter student's name: ");
            //    string name = Console.ReadLine();
            //    names[i] = name;
            //    int grade;
            //    do
            //    {
            //        Console.Write("Enter student's grade: ");
            //        string gradeStr = Console.ReadLine();
            //        Console.Clear();
            //        bool result = int.TryParse(gradeStr, out grade);
            //        if (!result||(result&& grade<0)||(result&& grade>100))
            //        {
            //            Console.WriteLine("wrong entry");
            //            bool again = TryAgain();
            //            if (!again) return;
            //        }
            //        else break;
            //    } while (true);
            //    grades[i] = grade;
            //}

            //do
            //{
            //    Console.WriteLine("1.Butun telebeleri goster" +
            //        "\n2.Orta bali goster" +
            //        "\n3.En yuksek bali goster" +
            //        "\n4.En asagi bali goster" +
            //        "\n5.Keçen telebeleri goster" +
            //        "\n6.Kesilen telebeleri goster" +
            //        "\n7.Ada gore telebe axtar" +
            //        "\n8.Qiymeti deyis"+
            //        "\n0.Çixiş\n");
            //    int answer;
            //    Console.Write("Choice:");
            //    string answerStr = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(answerStr, out answer);
            //    if (!result)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Enter a number only");
            //        Console.ResetColor();
            //        continue;
            //    }
            //    int index;
            //    switch (answer)
            //    {
            //        case 1:
            //            ShowAll(grades,names);
            //            break;
            //        case 2:
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine($"Average: {Average(grades)}");
            //            Console.ResetColor();
            //            break;
            //        case 3:
            //            index = MaxGrade(grades);
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine($"En yuksek balli telebe:\t{names[index]} - {grades[index]}");
            //            Console.ResetColor();
            //            break;
            //        case 4:
            //            index = MinGrade(grades);
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine($"En asagi balli telebe:\t{names[index]} - {grades[index]}");
            //            Console.ResetColor();
            //            break;
            //        case 5:
            //            ShowPassed(grades,names);
            //            break;
            //        case 6:
            //            ShowFailed(grades,names);
            //            break;
            //        case 7:
            //            index = SearchStudent(names);
            //            if (index >= 0)
            //            {
            //                Console.ForegroundColor = ConsoleColor.Green;
            //                Console.WriteLine($"Student {names[index]} got {grades[index]}");
            //                Console.ResetColor();
            //            }
            //            break;
            //        case 8:
            //            ChangeGrade(names, grades);
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("Succesfully Changed!");
            //            Console.ResetColor();
            //            break;
            //        case 0:
            //            Console.ForegroundColor= ConsoleColor.Yellow;
            //            Console.WriteLine("Have a nice day!");
            //            Console.ResetColor();
            //            return;
            //        default:
            //            Console.ForegroundColor= ConsoleColor.Red;
            //            Console.WriteLine("There is no such option in menu");
            //            Console.ResetColor();
            //            break;
            //    }
            //} while(true); 
            #endregion

        }
        public static bool IsPolidrom(string str)
        {
            int step = 0;
            bool result = true;
            if (str.Length % 2 != 0)
            {
                step = (str.Length - 1) / 2 - 1;
            }
            else
            {
                step = str.Length / 2 - 1;
            }
            for (int i = 0; i <= step; i++)
            {
                if (str[i] != str[(str.Length - 1 - i)])
                {
                    return false;
                }
            }
            return true;
        }
        public static int Max(int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            return max;
        }
        public static bool IsEven(int num)
        {
            return num % 2 == 0&&num>=0;//menfi ededin teki cutu olmur
        }
        public static void ChangeGrade(string[] names, int[] grades)
        {
            int index=0;
            do
            {
                index = SearchStudent(names);
            } while (index < 0);
            int grade;
            do
            {
                Console.Write("what would you liek to chnage the grade to:");
                string gradeStr = Console.ReadLine();
                Console.Clear();
                bool result = int.TryParse(gradeStr, out grade);
                if (!result || (result && grade < 0) || (result && grade > 100))
                {
                    Console.WriteLine("wrong entry");
                    bool again = TryAgain();
                    if (!again) return;
                }
                else break;
            } while (true);
            grades[index]=grade;
        }
        public static int SearchStudent(string[] names)
        {
            Console.Write("Enter name please: ");
            string name=Console.ReadLine();
            Console.Clear();
            for (int i=0; i<names.Length; i++)
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
