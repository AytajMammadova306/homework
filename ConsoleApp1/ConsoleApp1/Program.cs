namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            //Console.WriteLine("Mebleğ daxil et(AZN):");
            //string str = Console.ReadLine();
            //double num;
            //bool result = double.TryParse(str, out num);
            //Console.Clear();
            //if (result == false)
            //{
            //    Console.WriteLine("Sevh Daxil etdiniz");
            //    return;
            //}
            //Console.WriteLine("Secim et:");
            //Console.WriteLine($"1 - USD\n2 - EUR\n3 - TL");
            //string answer = Console.ReadLine();
            //Console.Clear();
            //if (answer == "1") Console.WriteLine(num+" AZN In USD: "+num*0.588);
            //else if(answer=="2") Console.WriteLine(num + " AZN In EUR: " + num*0.5083);
            //else if(answer=="3") Console.WriteLine(num + " AZN In TL: " + num* 27.23);
            //else Console.WriteLine("Sevh Daxil etdiniz");


            //Task2

            //Console.WriteLine("Enter a number:");
            //string str2 = Console.ReadLine();
            //int num2;
            //bool result2= int.TryParse(str2, out num2);
            //if(num2>0) Console.WriteLine("Positive");
            //else if(num2<0) Console.WriteLine("Negative");
            //else if(result==false) Console.WriteLine("enterd wrong");
            //else Console.WriteLine("Zero");

            //Task3

            Console.WriteLine("Enter a Number please:");
            string str3=Console.ReadLine();
            int num3;
            bool result3= int.TryParse(str3, out num3);
            Console.Clear();
            if (result3 == false)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            Console.WriteLine("Enter a Number again please:");
            string str4 = Console.ReadLine();
            int num4;
            bool result4 = int.TryParse(str4, out num4);
            Console.Clear();
            if (result4 == false)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            if (num3>num4) Console.WriteLine(num3+" is larger than "+num4);
            else if(num4>num3) Console.WriteLine(num4 + " is larger than " + num3);
            else Console.WriteLine("They are equal");


            //Ders vaxti: 

            //Console.WriteLine("Enter your grade:");
            //int grade;
            //bool result = int.TryParse(Console.ReadLine(), out grade);
            //if (result && grade > 51 && grade <= 100)
            //{
            //    Console.WriteLine("Kecdiniz");
            //}
            //else if (result == false || grade < 0 || grade > 100)
            //{
            //    Console.WriteLine("sehv daxil etdiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Kesildiniz");
            //}


            //Console.WriteLine("LogIn ( Adini Yaz!! )");
            //string name = Console.ReadLine();
            //if (name == "Aytaj")
            //{
            //    Console.WriteLine("Welcome!");
            //}
            //else Console.WriteLine("Olmadi!!");


        }
    }
}
