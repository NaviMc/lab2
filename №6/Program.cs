using System;

namespace number6
{
    class Program
    {
        static void Main()
        {
        int N;
        check:
            try
            {
                Console.WriteLine("Введите число N: ");
                N = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число: ");
                goto check;
            }
            if (N > 100 || N < 1)
            {
                Console.WriteLine("N должен быть от одного до ста, попробуй ещё раз: ");
                goto check;
            }
            else
            {
                if (N % 10 == 1 & (N > 11 || N < 2))
                {
                    Console.WriteLine($"{N} год");
                }
                else if (N % 10 < 5 & N % 10 > 1)
                {
                    Console.WriteLine($"{N} года");
                }
                else
                {
                    Console.WriteLine($"{N} лет");
                }
            }
        }
    }
}
