using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Metrics;

namespace homework_godknows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region positive
            //int[] arr = { -4, 8, 0, 15, -2, 7 };
            //int counter = 0;
            //foreach(int i in arr)
            //{
            //    if(i>0) counter++;
            //}
            //Console.WriteLine(counter); 
            #endregion


            #region >10
            //int[] arr = { 5, 14, 3, 22, 11, 8 };
            //int counter = 0;
            //foreach (int i in arr)
            //{
            //    if (i > 10) counter++;
            //}
            //Console.WriteLine(counter); 
            #endregion

            #region even
            //int[] arr = { 6, 9, 12, 5, 8, 3 };
            //int counter = 0;
            //foreach (int i in arr)
            //{
            //    if (i%2==0) counter++;
            //}
            //Console.WriteLine(counter); 
            #endregion

            #region indeEven
            //int[] arr = { 7, 4, 12, 8, 3, 15, 9 };
            //int sum = 0;
            //for (int i=0;i<arr.Length;i++)
            //{
            //    if (i % 2 == 0) sum += arr[i];
            //}
            //Console.WriteLine(sum); 
            #endregion


            #region isInArray
            //int[] arr = { 12, 7, 19, 4, 25 };
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter Number:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out num);
            //    if (!result)
            //    {
            //        bool loop = TryAgain();
            //        if (!loop) return;
            //    }
            //    else break;
            //} while (true);
            //foreach(int i in arr)
            //{
            //    if(i==num)
            //    {
            //        Console.WriteLine("this number is in array");
            //        return;
            //    }
            //}
            //Console.WriteLine("it is not in array"); 
            #endregion

            #region average
            //int sum = 0;
            //int[] arr = { 5, 10, 15, 20, 25 };
            //foreach (int i in arr) sum += i;
            //Console.WriteLine(sum/arr.Length); 
            #endregion

            #region reverse
            //int[] arr = { 2, 4, 6, 8, 10 };
            //for (int i=arr.Length-1; i>=0; i--)
            //{
            //    Console.Write(arr[i]+" ");
            //} 
            #endregion

            #region negative
            //int[] arr = { -3, 7, -1, 8, -9, 4 };
            //int count = 0;
            //foreach(int i in arr) if(i<0) count++;
            //int[] newarr= new int[count];
            //for(int i=arr.Length-1; i>=0; i--)
            //{
            //    if (arr[i] < 0)
            //    {
            //        newarr[--count] = arr[i];
            //    }

            //}
            //foreach(int i in newarr)
            //{
            //    Console.Write(i+" ");
            //} 
            #endregion

            #region largeThanN
            //int[] arr = { 3, 15, 8, 22, 10, 17 };
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter Number:");
            //    string str = Console.ReadLine();
            //    Console.Clear();
            //    bool result = int.TryParse(str, out num);
            //    if (!result)
            //    {
            //        bool loop = TryAgain();
            //        if (!loop) return;
            //    }
            //    else break;
            //} while (true);
            //int count = 0;
            //foreach(int i in arr) if(i>num) count++;
            //int[] newarr= new int[count];
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    if (arr[i] > num) newarr[--count] = arr[i];
            //}
            //foreach(int i in newarr) Console.Write(i+" "); 
            #endregion

            #region repeat
            //int[] arr = { 2, 5, 2, 8, 5, 1, 8 };
            //int[] newarr= new int[arr.Length];
            //int indexer = 0;
            //foreach(int i in arr)
            //{
            //    int counter = 0;
            //    foreach(int j in arr) if(i == j) counter++;
            //    if (counter != 1&& !newarr.Contains(i))
            //    {
            //        newarr[indexer]=i;
            //        indexer++;
            //        Console.WriteLine(i+" - "+(counter)+"defe");
            //    }
            //} 
            #endregion

            #region secondMax
            //int[] arr = { 12, 45, 7, 23, 45, 18 };
            //int secondMax;
            //int max;
            //if (arr[0] > arr[1])
            //{
            //    max = arr[0];
            //    secondMax = arr[1];
            //}
            //else
            //{
            //    max = arr[1];
            //    secondMax = arr[0];
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
            //int[] arr = { 3, 7, 10, 15, 18 };
            //bool checker = true;
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    if (arr[i] > arr[i + 1]) checker = false;
            //}
            //if (checker) Console.WriteLine("artan sira iledi");
            //else Console.WriteLine("artan sira ile deyil"); 
            #endregion

            #region football
            //string[] players =
            //    {
            //    "Messi",
            //    "Ronaldo",
            //    "Mbappe",
            //    "Haaland",
            //    "Salah"
            //    };
            //int[] goals = { 25, 19, 31, 31, 17 };
            //int maxIndex = 0;
            //int moreThan = 0;
            //for (int i = 0; i < players.Length; i++)
            //{
            //    if (goals[i] > goals[maxIndex]) maxIndex = i;
            //    if (goals[i] > 20) moreThan++;
            //}
            //Console.WriteLine(players[maxIndex] + " had scored most");
            //Console.WriteLine(moreThan + " players scored more than 20 goals");
            //string[] moreNames = new string[moreThan];
            //for(int i = goals.Length-1; i >= 0; i--)
            //{
            //    if (goals[i] > 20) moreNames[--moreThan] = players[i];
            //}
            //foreach(string name in moreNames)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion

            #region shop
            //string[] products =
            //    {
            //    "Telefon",
            //    "Noutbuk",
            //    "Qulaqliq",
            //    "Monitor",
            //    "Telefon",
            //    "Mouse",
            //    "Monitor"
            //    };
            //int[] prices = { 1200, 2500, 150, 600, 1400, 80, 750 };
            //string product = Console.ReadLine();
            //int expensive = default;
            //bool checker = false;
            //int counter = 0;
            //for(int i =0;i<products.Length;i++)
            //{
            //    if (products[i] == product)
            //    {
            //        counter++;
            //        if (expensive < prices[i]) expensive = prices[i];
            //        Console.WriteLine(prices[i]);
            //        checker = true;
            //    }
            //}
            //if(!checker) Console.WriteLine("Is not found");
            //else Console.WriteLine("Most expensive is for "+expensive); 
            #endregion
        }
        public static bool TryAgain()
        {
            do
            {
                Console.WriteLine("would you like to try agian?(Y/N)");
                string str = Console.ReadLine();
                Console.Clear();
                if (str.ToUpper() == "Y") return true;
                else if (str.ToUpper() == "N") return false;
                else
                {
                    Console.WriteLine("Enter Y or N");
                }
            } while (true);
        }
    }
}
