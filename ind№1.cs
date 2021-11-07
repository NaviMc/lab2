using System;

namespace indnumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool res = true;
            double x1, y1;
        check1:
            try
            {
                Console.WriteLine("Введите координату x точки A: ");
                x1 = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число, попробуйте ещё раз: ");
                goto check1;
            }
        check2:    
            try
            {
                Console.WriteLine("Введите координату y точки A: ");
                y1 = double.Parse(Console.ReadLine());
            } catch(FormatException)
            {
                Console.WriteLine("Вы ввели не число, попробуйте ещё раз: ");
                goto check2;
            }
            if (x1 == 0 || y1 == 0)
            {
                Console.WriteLine("Zero Coord");
                goto check1;
            }
            else if (x1 > 0 && y1 > 0)
                Console.WriteLine("Точка A лежит в 1-ой четверти");
            else if (x1 < 0 && y1 > 0)
                Console.WriteLine("Точка A лежит во 2-ой четверти");
            else if (x1 < 0 && y1 < 0)
                Console.WriteLine("Точка A лежит в 3-ей четверти");
            else if (x1 > 0 || y1 < 0) 
                Console.WriteLine("Точка A лежит в 4-ой четверти");

            double x2, y2;
            check3:
            try
            {
                Console.WriteLine("Введите координату x точки B: ");
                x2 = double.Parse(Console.ReadLine());
            }catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число, попробуйте ещё раз: ");
                goto check3;
            }
            check4:
            try
            {
                Console.WriteLine("Введите координату y точки B: ");
                y2 = double.Parse(Console.ReadLine());
            }catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число, попробуйте ещё раз: ");
                goto check4;
            }
            if (x2 == 0 || y2 == 0)
            {
                Console.WriteLine("Zero Coord");
                goto check3;
            }
            else if (x2 > 0 && y2 > 0)
                Console.WriteLine("Точка B лежит в 1-ой четверти");
            else if (x2 < 0 && y2 > 0)
                Console.WriteLine("Точка B лежит во 2-ой четверти");
            else if (x2 < 0 && y2 < 0)
                Console.WriteLine("Точка B лежит в 3-ей четверти");
            else if (x2 > 0 && y2 < 0)
                Console.WriteLine("Точка B лежит в 4-ой четверти");
            Console.WriteLine("Определим, в одной ли четверти находятся точки: ");
            if ((x1 > 0 && y1 > 0) && (x2 > 0 && y2 > 0))
                Console.WriteLine(res);
            else if ((x1 < 0 && y1 > 0) && (x2 < 0 && y2 > 0))
                Console.WriteLine(res);
            else if ((x1 < 0 && y1 < 0) && (x2 < 0 && y2 < 0))
                Console.WriteLine(res);
            else if ((x1 > 0 && y1 < 0) && (x2 > 0 && y2 < 0))
                Console.WriteLine(res);
            else
            {
                res = false;
                Console.WriteLine(res);
            }
        }
    }
}
