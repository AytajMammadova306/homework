namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(IsEven(2));
            //Console.WriteLine(IsEven(7));
            //Console.WriteLine(IsEven(-2));


            //Console.WriteLine(GetMax(2,6));
            //Console.WriteLine(GetMax(8,6));
            //Console.WriteLine(GetMax(6,6));

            //Console.WriteLine(GetSum([1,5,3]));
            //Console.WriteLine(GetSum([1]));
            //Console.WriteLine(GetSum([1,5,5]));

            //Console.WriteLine(CountPositive([1, -5, -3]));
            //Console.WriteLine(CountPositive([1]));
            //Console.WriteLine(CountPositive([-1, -5, -5]));

            //Console.WriteLine(IsPrime(4));
            //Console.WriteLine(IsPrime(2));
            //Console.WriteLine(IsPrime(3));

            //Console.WriteLine(GetMax([2, 4, 7, 1]));
            //Console.WriteLine(GetMax([9, 4, 7, 1]));

            //Console.WriteLine(GetDifference([1,5,8,2]));

            foreach(int i in GetEvenNumbers([2,5,3,0]))
            {
                Console.Write(i+" ");
            }


        }
        public static bool IsEven(int num)
        {
            if(num%2==0) return true;
            return false;
        }
        public static int GetMax(int a, int b)
        {
            if (a > b) return a;
            return b;
        }
        public static int GetSum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr) sum += i;
            return sum;
        }
        public static int CountPositive(int[] arr)
        {
            int count = 0;
            foreach (int i in arr) if (i>0)count++;
            return count;
        }
        public static bool IsPrime(int number)
        {
            for(int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr) if (i > max) max = i;
            return max;
        }
        public static int GetDifference(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            foreach(int i in arr)
            {
                if (i < min) min = i;
                if (i > max) max = i;
            }
            return max-min;

        }
        public static int[] GetEvenNumbers(int[] arr)
        {
            int count = 0;
            foreach (int i in arr) if (i % 2 == 0) count++;
            int[] newarr= new int[count];
            for(int i =arr.Length-1; i >= 0; i--)
            {
                if(arr[i] % 2 == 0) newarr[--count] = arr[i];
            }
            return newarr;
        }
    }
}
