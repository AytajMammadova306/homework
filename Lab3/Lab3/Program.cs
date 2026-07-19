using System;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int length;
            do
            {
                Console.WriteLine("Enter amounts of prodeucts:");
                string str=Console.ReadLine();
                Console.Clear();
                bool result=int.TryParse(str, out length);
                if (!result)
                {
                    if (!TryAgain()) return;
                }
                else break;
            }while (true);
            int[] stocks=new int[length];
            string[] names= new string[length];
            for (int i=0;i<length;i++)
            {
                Console.Write("Please enter name of product:");
                string name = Console.ReadLine();
                int stock;
                do
                {
                    Console.Write("Please enter stocks of product:");
                    string str = Console.ReadLine();
                    Console.Clear();
                    bool result = int.TryParse(str, out stock);
                    if (!result||(result&&stock<0))
                    {
                        if (!TryAgain()) return;
                    }
                    else break;
                } while (true);
                names[i] = name;
                stocks[i] = stock;
            }

            do
            {
                Console.WriteLine("1. Butun mehsullari goster\n" +
                    "2. Umumi mehsul sayini goster\n" +
                    "3. En cox olan mehsulu goster\n" +
                    "4. En az olan mehsulu goster\n" +
                    "5. Mueyyen saydan cox olan mehsullari goster\n" +
                    "6. Mehsul axtar\n" +
                    "7. Yeni mehsul sayi elave et\n" +
                    "8. Mehsulu sil\n" +
                    "9. Butun mehsullarin orta sayini hesabla.\n" +
                    "10. Anbarda olmayan mehsullari goster.\n" +
                    "11. Cixis ");
                string answer=Console.ReadLine();
                Console.Clear();
                int index;
                switch (answer)
                {
                    case "1":
                        ShowProducts(stocks, names);
                        break;
                    case "2":
                        Console.WriteLine(names.Length);//Bunu ayri methoda yazmadim...
                        break;
                    case "3":
                        GetMaxProduct(stocks,names);
                        break;
                    case "4":
                        GetMinProduct(stocks,names);
                        break;
                    case "5":
                        ShowProductsGreaterThan(stocks,names);
                        break;
                    case "6":
                        SearchProduct(stocks, names);
                        break;
                    case "7":
                        AddCount(ref stocks, ref names);
                        break;
                    case "8":
                        RemoveProduct(ref stocks, ref names);
                        break;
                    case "9":
                        GetAverage(stocks);
                        break;
                    case "10":
                        NotInStock(stocks,names);
                        break;
                    case "11":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong entry. Try again!");
                        Console.ResetColor();
                        break;
                }
            }while (true);

        }
        public static void RemoveProduct(ref int[] stocks, ref string[] names)
        {
            Console.Write("Please enter name of product you want to delete:");
            string name = Console.ReadLine();
            Console.Clear();
            bool hadSeen = false;
            foreach(string str in names)
            {
                if(str==name) hadSeen = true;
            }
            if (!hadSeen)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("there is not such product");
                Console.ResetColor();
                return;
            }
            hadSeen = false;
            int[] newstocks= new int[stocks.Length-1];
            string[] newnames= new string[stocks.Length-1];
            for(int i = 0; i < stocks.Length; i++)
            {
                if (name != names[i])
                {
                    if (hadSeen)
                    {
                        newnames[i - 1] = names[i];
                        newstocks[i-1] = stocks[i];
                    }
                    else
                    {
                        newnames[i]= names[i];
                        newstocks[i]= stocks[i];
                    }
                }
                else hadSeen = true;
                
            }
            names=newnames;
            stocks=newstocks;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Deleted Succesfully");
            Console.ResetColor();

        }
        public static void NotInStock(int[] stocks, string[] names)
        {
            bool checker = true;
            for(int i = 0; i < stocks.Length; i++)
            {
                if (stocks[i] == 0)
                {
                    Console.WriteLine(names[i] + " - " + stocks[i]);
                    checker = false;
                }
            }
            if(checker) Console.WriteLine("Everything is in stock");
        }
        public static void GetAverage(int[] stocks)
        {
            int sum = 0;
            foreach (int i in stocks) sum += i;
            Console.WriteLine((double)sum/stocks.Length);
        }
        public static void SearchProduct(int[] stocks, string[] names)
        {
            Console.WriteLine("Enter product name you are looking for:");
            string name = Console.ReadLine();
            Console.Clear();
            for(int i =0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    Console.WriteLine(name+" - " + stocks[i]);
                    return;
                }
            }
            Console.WriteLine("There is no such product");
        }
        public static void AddCount(ref int[] stocks, ref string[] names)
        {
            int addition;
            do
            {
                Console.Write("Please enter number of product you want to add:");
                string str = Console.ReadLine();
                Console.Clear();
                bool result = int.TryParse(str, out addition);
                if (!result)
                {
                    if (!TryAgain()) return;
                }
                else break;
            } while (true);
            int[] newstocks = new int[stocks.Length + addition];
            string[] newnames = new string[names.Length + addition];
            for(int i=0;i<stocks.Length;i++)
            {
                newstocks[i] = stocks[i];
                newnames[i] = names[i];
            }
            for(int i = stocks.Length; i < addition + stocks.Length; i++)
            {
                Console.Write("Please enter name of product:");
                string name = Console.ReadLine();
                int stock;
                do
                {
                    Console.Write("Please enter stocks of product:");
                    string str = Console.ReadLine();
                    Console.Clear();
                    bool result = int.TryParse(str, out stock);
                    if (!result)
                    {
                        if (!TryAgain()) return;
                    }
                    else break;
                } while (true);
                newnames[i] = name;
                newstocks[i] = stock;
            }
            names = newnames;
            stocks = newstocks;
        }
        public static void ShowProductsGreaterThan( int[] stocks, string[]names)
        {
            int number;
            do
            {
                Console.Write("Please enter stocks of product you are looking for:");
                string str = Console.ReadLine();
                Console.Clear();
                bool result = int.TryParse(str, out number);
                if (!result)
                {
                    if (!TryAgain()) return;
                }
                else break;
            } while (true);
            for (int i=0;i<stocks.Length;i++)
            {
                if(stocks[i] > number)
                {
                    Console.WriteLine(names[i] + " - " + stocks[i]);
                }
            }
        }
        public static void GetMinProduct(int[] stocks, string[] names)
        {
            int index = 0;
            for(int i = 0; i < stocks.Length; i++)
            {
                if (stocks[i] < stocks[index]) index = i;
            }
            Console.WriteLine(names[index] + " - " + stocks[index]);
        }
        public static void GetMaxProduct(int[] stocks, string[] names)
        {
            int index = 0;
            for(int i = 0; i < stocks.Length; i++)
            {
                if (stocks[i] > stocks[index]) index = i;
            }
            Console.WriteLine(names[index] + " - " + stocks[index]);
        }
        public static void ShowProducts(int[] stocks, string[] names)
        {
            for (int i = 0; i < stocks.Length; i++)
            {
                Console.WriteLine(names[i]+" - " + stocks[i]);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nPress any key to go back to meny...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        public static bool TryAgain()
        {
            do
            {
                Console.WriteLine("Would you like to try again?(Y/N)");
                string answer= Console.ReadLine();
                Console.Clear();
                if (answer.ToUpper() == "Y") return true;
                else if (answer.ToUpper() == "N") return false;
                else Console.WriteLine("Please enter Y or N");
            } while (true);
        }
        
    }
}
