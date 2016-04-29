using System;

namespace Recursion3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select 1.Factorial 2.Fibonacci 3.Gcd");
                int operation = int.Parse(Console.ReadLine());
                switch (operation)
                {

                    case 1:
                        Console.WriteLine("Enter the rquired Factorial");
                        int number = int.Parse(Console.ReadLine());

                        Console.WriteLine(Factorial(number));
                        break;

                    case 2:
                        Console.WriteLine("Enter the required Fibonacci number");
                        int count = int.Parse(Console.ReadLine());

                        Console.WriteLine(GenerateFibonacci(count));
                        break;

                    case 3:
                        Console.WriteLine("Enter the first number to get Gcd");
                        int number1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the second number to get Gcd");
                        int number2 = int.Parse(Console.ReadLine());

                        Console.WriteLine(Gcd(number1, number2));
                        break;

                    default:
                        Console.WriteLine("Unknown");
                        break;

                }
            }
        }

        public static long Factorial(long number)
        {
            // base condition - if the number is 0 or 1, return 1
            if (number <= 1)
                return 1;
            else
            {
                // recursive call to get the factorial again
                return number * Factorial(number - 1);
            }
        }

        public static int GenerateFibonacci(int count)
        {
            if (count <= 1)
                return 1;
            else
                return GenerateFibonacci(count - 1) + GenerateFibonacci(count - 2);
        }

        public static int Gcd(int number1, int number2)
        {
            // find the remainder
            int remainder = number1 % number2;
            // base condition - if the number divide
            if (remainder == 0)
                return number2;
            else // recurse
                return Gcd(number2, remainder);
        }
    }
}
