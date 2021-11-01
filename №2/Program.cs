using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int col;
            check:
            try
            {
                Console.WriteLine("Обозначте количество слагаемых: ");
                col = int.Parse(Console.ReadLine());
            }catch(FormatException)
            {
                Console.WriteLine("Вы ввели не число, попробуйте ещё раз: ");
                goto check;
            }
            if (col < 1)
            {
                Console.WriteLine("Количество слогаемых не может быть меньше 1, попробуйте ещё раз: ");
                goto check;
            }
            double znam = 3;
            double chis = 1;
            for (int i = 0; i < col; i++)
            {
                chis = chis - (1 / znam) + (1 / (znam + 2));
                znam += 4;
            }
            double res = chis * 4;
            Console.WriteLine(res);
        }
    }
}
