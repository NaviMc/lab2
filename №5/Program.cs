using System;

namespace number5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
        check:
            try
            {
                Console.WriteLine("Введите число");
                N = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число");
                goto check;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Такое большое число нельзя обработать введите другое");
                goto check;
            }
            bool isImpossible = true;
            for (int i = 1; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    for (int k = j; k < N; k++)
                    {
                        if (Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(k, 3) == N)
                        {
                            Console.WriteLine($"Данное число можно разложить так: {i}^3 + {j}^3 + {k}^3");
                            isImpossible = false;
                        }
                    }
                }
            }
            if (isImpossible)
            {
                Console.WriteLine("No such combinations!");
            }
        }
    }
}
