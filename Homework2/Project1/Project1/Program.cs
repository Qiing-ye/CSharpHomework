using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 2;
            string N;
            N = Console.ReadLine();
            double n = 0;
            while (!double.TryParse(N, out n))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                N = Console.ReadLine();
            }
            Console.Write("n=");
            while (n != 1)
            {
                if (n % i == 0)
                {
                    if (n == i)
                        Console.Write(i);
                    else
                        Console.Write(i+"*");
                    n /= i;
                }
                if (n % i != 0)
                    i++;
            }
        }
    }
}
