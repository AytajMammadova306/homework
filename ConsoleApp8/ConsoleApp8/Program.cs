namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter number:");
            //    string answer= Console.ReadLine();
            //    Console.Clear();
            //    bool result= int.TryParse(answer, out num);
            //    if (!result)
            //    {
            //        bool loop = TryAgain();
            //        if (!loop)
            //        {
            //            Console.Clear();
            //            return;
            //        }    
            //    }
            //    else break;
            //} while (true);
            //int f = 1;
            //for(int i=1;i<=num;i++)
            //{
            //    f *= i;
            //}
            //Console.WriteLine(f);





            //int num;
            //do
            //{
            //    Console.WriteLine("Enter number:");
            //    string answer= Console.ReadLine();
            //    Console.Clear();
            //    bool result= int.TryParse(answer, out num);
            //    if (!result)
            //    {
            //        bool loop = TryAgain();
            //        if (!loop)
            //        {
            //            Console.Clear();
            //            return;
            //        }    
            //    }
            //    else break;
            //} while (true);
            //int sum = 0;
            //for(int i=1;i<=num;i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine((num+1)*num/2);
            //Console.WriteLine(sum);





            #region triangle
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
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        for (int j = 0; j < arr.Length; j++)
            //        {
            //            if (i != j && arr[i] == arr[j]) count++;
            //        }
            //    }
            //    if (count == 6) Console.WriteLine("Beraberterefli");
            //    else if (count == 2) Console.WriteLine("beraberyanli");
            //    else Console.WriteLine("muxtelif terefli");

            //}
            //else Console.WriteLine("that is not a triangle"); 
            #endregion

            #region ticket
            //int num;
            //do
            //{
            //    Console.WriteLine($"age:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out num);
            //    if (!result||(result&&(num<0||num>120)))
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //if (num > 60)
            //{
            //    Console.WriteLine("Bilet 7 manatdir");
            //}
            //else if(num<60&&num>18)
            //{
            //    Console.WriteLine("Bilet 10 manatdir");

            //}
            //else
            //{
            //    Console.WriteLine("Usaq bileti");
            //    if(num>6) Console.WriteLine("Bilet 5 manatdir");
            //    else Console.WriteLine("Pulsuz");
            //} 
            #endregion

            #region Sum
            //int num;
            //do
            //{
            //    Console.WriteLine($"number:");
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
            //while (num != 0)
            //{
            //    sum += num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine(sum); 
            #endregion

            #region reverse
            //int num;
            //do
            //{
            //    Console.WriteLine($"number:");
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
            //int rev = 0;
            //while (num != 0)
            //{
            //    rev= rev*10+( num % 10);
            //    num /= 10;
            //}
            //Console.WriteLine(rev); 
            #endregion


            #region digitCount
            //int num;
            //do
            //{
            //    Console.WriteLine($"eded:");
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
            //int digit=0;
            //do
            //{
            //    Console.WriteLine($"digit:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out digit);
            //    if (!result||!(result &&digit/10==0))
            //    {
            //        Console.WriteLine("wrong entry");
            //        bool again = TryAgain();
            //        if (!again) return;
            //    }
            //    else break;
            //} while (true);
            //int count = 0;
            //while (num != 0)
            //{
            //    if (num % 10 == digit) count++;
            //    num /= 10;
            //}
            //Console.WriteLine(count); 
            #endregion
        }
        public static bool TryAgain()
        {
            do
            {
                Console.WriteLine("Would you like to try again?(Y/N)");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "Y")
                {
                    Console.Clear();
                    return true;
                }
                else if (answer.ToUpper() == "N")
                {
                    return false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter Y or N");
                }
            } while (true);
        }
    }
}
