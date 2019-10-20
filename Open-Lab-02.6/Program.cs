using System;

namespace Open_Lab_02._6
{
    class Program
    {
        public static bool Divisible(int a)
        {
            return (a % 100 == 0);
        }

        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Divisible(b));
        }
    }
}
