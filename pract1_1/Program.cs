using System;

namespace pract1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string sa, sb;
            Console.WriteLine("I. Написать программу, которая подсчитывает: \n7) периметр прямоугольного треугольника по двум катетам a, b.\n");
            Console.WriteLine("\t~Поиск  периметра~\n\t ~прямоугольного~\n\t  ~треугольника~\n");
            do
            {
                Console.Write("Катет a: ");
                sa = Console.ReadLine();
                Console.Write("Катет b: ");
                sb = Console.ReadLine();
                Console.WriteLine();

            } while (!Double.TryParse(sa, out a) || !Double.TryParse(sb, out b));
            if (Double.TryParse(sa, out a) && Double.TryParse(sb, out b));
            {
                double p = Math.Sqrt(a * a + b * b) + a + b;
                Console.WriteLine("\n\tПериметр Р = " + Math.Round(p, 3));
            }

            Console.WriteLine("\n\nII. Написать программу, которая определяет: \n7) одинаковы ли цифры данного двухзначного числа.\n");
            Console.WriteLine("\t~Двузначные числа~\n");
            string sc;
            int c, o, v;
            do
            {
                Console.Write("Введите двузначное число: ");
                sc = Console.ReadLine();
            }
            while (!int.TryParse(sc, out c)||Convert.ToInt32(sc) < 10 || Convert.ToInt32(sc) > 99 );

            o = Convert.ToInt32(c / 10);
            v = c % 10;
            if (o == v)
            {
                Console.Write("\nЦифры данного двухзначного числа одинаковы\n");
            }
            else
            {
                Console.Write("\nЦифры данного двухзначного числа не одинаковы\n");
            }
                                    
        }
    }
}
