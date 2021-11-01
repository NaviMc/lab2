using System;

namespace number1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Дано квадратное уравнение ax2 + bx + c = 0");
            double a, b, c, D, x, x1, x2;
        checknumber1:
            try
            {
                Console.WriteLine("Введите а:");
                a = Convert.ToDouble(Console.ReadLine());
                while (a == 0)
                {
                    Console.WriteLine("Число не должно равняться 0, попробуйте ещё раз: ");
                    goto checknumber1;
                }
            } catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число, попробуйте ещё раз: ");
                goto checknumber1;
            }
        checknumber2:
            try
            {
                Console.WriteLine("Введите b:");
                b = Convert.ToDouble(Console.ReadLine());
                while (b == 0)
                {
                    Console.WriteLine("Число не должно равняться 0, попробуйте ещё раз: ");
                    goto checknumber2;
                }
            } catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число, попробуйте ещё раз: ");
                goto checknumber2;
            }
        checknumber3:
            try
            {
                Console.WriteLine("Введите c:");
                c = Convert.ToDouble(Console.ReadLine());
                while (c == 0)
                {
                    Console.WriteLine("Число не должно равняться 0, попробуйте ещё раз: ");
                    goto checknumber3;
                }
            } catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число, попробуйте ещё раз: ");
                goto checknumber3;
            }
            D = Math.Pow(b, 2) - 4 * a * c;

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                if (x1 >= 0)
                    Console.WriteLine($"x1 = {x1}");
                else
                    Console.WriteLine("x1 - недействительное число");
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                if (x2 >= 0)
                    Console.WriteLine($"x2 = {x2}");
                else
                    Console.WriteLine("x2 - недействительное число");
            }
            else if (D == 0)
            {
                x = -b / 2 * a;
                if (x >= 0)
                    Console.WriteLine($"x = {x}");
                else
                    Console.WriteLine("действительных корней не существует");
            }
            else
                Console.WriteLine($"Корни уравнения можно представить в виде комплексных чисел: ({-b} + i{D})/{2 * a} , ({-b} - i{D})/{2 * a}");
        }
    }
}