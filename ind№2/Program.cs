using System;

class Program
{
    static void Main(string[] args)
    {
        int a;
        bool result = false;
    check:
        try
        {
            Console.WriteLine("Введите число от 1 до 100000: ");
            a = int.Parse(Console.ReadLine());
        }catch(FormatException)
        {
            Console.WriteLine("Вы ввели не число, попробуйте ещё раз: ");
            goto check;
        }
        if (a < 1 || a > 100000)
        {
            Console.WriteLine("Число введено некорректно, попробуйте ещё раз: ");
            goto check;
        }
        int k = 1;
        while (a >= Math.Pow(3, k))
        {
            if (a == Math.Pow(3, k))
            {
                    result = true;
                    break;
            }
            else
            {
                    result = false;
                    k++;
            }
        }
        if (!result)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine($"Степень, в которую возвели 3: {k}");
            Console.WriteLine(true);
        }
    }
}