namespace methods_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your word:");
            //string str=Console.ReadLine();
            //Console.WriteLine(Sait(str));


            //Console.Write("Enter your word:");
            //string str=Console.ReadLine();
            //Console.WriteLine(Palindrom(str));


            //Console.WriteLine(IsArtatan([1,2,3,5]));

            //Console.WriteLine(SecondMax([7,4,2,4,8]));


            //Console.WriteLine(AreArraysEqual([2,1,4], [2,1,3]));

        }
        public static int Sait(string str)
        {
            char[] chars = { 'a', 'o', 'u', 'e', 'i' };
            int count = 0;
            foreach(char c in str)
            {
                foreach(char c2 in chars) if (c == c2) count++;
            }
            return count;
        }
        public static bool Palindrom(string str)
        {
            string newstr = "";
            for (int i = str.Length - 1; i >= 0; i--) newstr += str[i];
            if (newstr == str) return true;
            else return false;
        }
        public static bool IsArtatan(int[] arr)
        {
            for(int i =0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i+1]) return false;
            }
            return true;
        }
        public static int SecondMax(int[] arr)
        {
            int max;
            int secondMax;
            if (arr[0] > arr[1])
            {
                max = arr[0];
                secondMax = arr[1];
            }
            else
            {
                max = arr[1];
                secondMax = arr[0];
            }
            foreach (int i in arr)
            {
                if (max < i)
                {
                    secondMax = max;
                    max = i;
                }
                else if (i > secondMax && i != max) secondMax = i;
            }
            return secondMax;
        }
        public static bool AreArraysEqual(int[] arr1, int[] arr2)
        {
            if(arr1.Length != arr2.Length) return false;
            for(int i=0; i<=arr1.Length-1; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }
            return true;
        }
    }
}
