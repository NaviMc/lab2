using System;

namespace number4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
        check1:
            try
            {
                Console.WriteLine("Введите значение cos(x)");
                x = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Вы ввели не число, попробуйте ещё раз: ");
                goto check1;
            }
            int col;
        check2:
            try
            {
                Console.WriteLine("Введите количество слагаемых: ");
                col = int.Parse(Console.ReadLine());
            }catch(FormatException)
            {
                Console.WriteLine("Вы ввели не число, попробуйте ещё раз: ");
                goto check2;
            }
            if (col < 1)
            {
                Console.WriteLine("Количество слагаемых не может быть меньше 1, попробуйте ещё раз: ");
                goto check1;
            }
            double y;
            double cos = 1;
            int a = 2;
            int r = -1;
            int col2 = 0;
            int k = 2;
            do
            {
                y = (Math.Pow(x, a) / F(k));
                cos += y * r;
                a += 2;
                k += 2;
                r *= -1;
                col2++;
            } while (Math.Abs(y) > col);
            Console.WriteLine($"cos(x) =  {cos}");
            Console.WriteLine($"Количество учтенных слагаемых: {col2} ");
        }
        public static int F(int k)
        {
            if (k == 0)
            {
                return 1;
            }
            else
            {
                return k * F(k - 1);
            }
        }
    }
}