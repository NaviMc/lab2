using System;

namespace number3
{
    class Program
    {
        static void Main(string[] args)
        {
            double f0 = 0;
            double f1 = 1;
            while (f1 < 1000)
            {
                double f = f0 + f1;
                f0 = f1;
                f1 = f;
            }
            int k = 0;
            while (f1 < 10000)
            {
                double f = f0 + f1;
                f0 = f1;
                f1 = f;
                k++;
            }
            Console.WriteLine($"Количество четырехзначных чисел в ряде Фибоначчи: {k}");
        }
    }
}
