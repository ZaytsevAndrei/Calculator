using System;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int counter = 0; counter < number; counter++)
                Console.WriteLine(" \n" + Fibonacci(counter));

        }

        public static int Fibonacci(int number)
        {

            if (number == 0)
                return 0;
            else if (number == 1)
                return 1;
            else
            {
                return Fibonacci(number - 2) + Fibonacci(number - 1);
            }

        }
    }
}