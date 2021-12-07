using System;

namespace pract5_1
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                if (Math.Round(x, 2) <= 0.5) throw new Exception();
                else return Math.Round(x / Math.Sqrt(2*x-1), 2);
            }
            catch
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Постройте таблицу значений функции y=f(x) на  \n[a, b]  с шагом h. Если в некоторой точке x \nфункция не определена, то выведите на экран \nсообщение об этом.\n\n\ty = x / Sqrt(2*x-1)\n");
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h = ");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine();
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine($"\ty({Math.Round(i, 2)})\t= {Math.Round(f(i), 2)}");
                    }                    
                    catch
                    {
                        Console.WriteLine($"\ty({Math.Round(i, 2)})\tне определена");
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }

    }
}
