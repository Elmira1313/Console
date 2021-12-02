using System;

namespace pract3_1
{
    class Program
    {
        static double f1(double n)
        {
            double r = Math.Sqrt(n) + n;
            return r;
        }
        static void zadanie1()
        {
            int n, o = 1;
            double x, z = 0;
            Console.WriteLine("I. Разработать метод f(n), который для заданного \nнатурального числа n находит значение scrt(n)+n. \nВычислить с помощью него значение выражения \n\n(scrt(6)+6)/2+(scrt(13)+13)/2+(scrt(21)+21)/2\n\n");

            while (o == 1)
            {
                try
                {
                    Console.Write("\tBведите кол-во слагаемых: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"n {i + 1} слагаемого: ");
                        x = double.Parse(Console.ReadLine());
                        z += f1(x) / 2;
                    }
                    Console.WriteLine($"\n\n\t~ Ответ: {Math.Round(z, 5)} ~\n");
                    o = 0;
                    //Console.Write($"Продолжить?\nДа - 1\nНет - 0\nОтвет: ");
                    //o = int.Parse(Console.ReadLine());
                    //Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine($"!Что-то введено не так!\nЕще раз!\n\n");
                }
            }

        }

        static double f2(double x)
        {
            double y = 0;
            if (x < 0) y = -4;
            else if(x >= 0 && x < 1) y = x * x + 3 * x + 4;
            else y = 2;
            return y;
        }
        static void zadanie2()
        {
            int o = 1;
            double a = 0, b = 0, h = 0;
            Console.WriteLine("II. Постройте таблицу значений функции y=f(x) \nдля  х принадлежащем [a, b]  с шагом h.\n\n");
            while (o == 1)
            {
                try
                {
                    Console.Write("a = ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("h = ");
                    h = double.Parse(Console.ReadLine());
                    for (double i = a; i <= b; i += h)
                    Console.WriteLine($"\nf({Math.Round(i, 2)})\t= {Math.Round(f2(i), 2)}");
                    o = 0;
                }
                catch (Exception)
                {
                    Console.WriteLine($"!Что-то введено не так!\nЕще раз!\n\n");
                }
            }

        }

        static void f1(double n, out double y)
        {
            y = (Math.Sqrt(n) + n)/2;
        }
        static void zadanie3()
        {
            int n, o = 1;
            double x, z1 = 0, z2 = 0, y=0;
            Console.WriteLine("III. Перегрузите метод f из I задания так,\nчтобы его сигнатура (заголовок) соответствовала виду \nstatic void f (double x, out double y).  \nПродемонстрируйте работу перегруженных методов\n\n");

            while (o == 1)
            {
                try
                {
                    Console.Write("\tBведите кол-во слагаемых: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"n {i + 1} слагаемого: ");
                        x = double.Parse(Console.ReadLine());
                        z1 += f1(x) / 2;

                        f1(x, out y);
                        z2 += y;
                    }
                    Console.WriteLine($"\n\n\t ~ Ответ I: {Math.Round(z1, 5)} ~");
                    Console.WriteLine($"\n\t~ Ответ III: {Math.Round(z2, 5)} ~\n");
                    o = 0;
                }
                catch (Exception)
                {
                    Console.WriteLine($"!Что-то введено не так!\nЕще раз!\n\n");
                }
            }
        }

        static void Main(string[] args)
        {
            int n=10, o=1;
            Console.WriteLine("\t~Всего 3 задания~\n0-выход\n");
            while (n != 0)
            {
                try
                {
                    Console.Write("Ведите номер задания: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (n)
                    {
                        case 0: Console.WriteLine("\t~Выход~"); break;
                        case 1: Program.zadanie1(); Console.WriteLine(""); break;
                        case 2: Program.zadanie2(); Console.WriteLine(""); break;
                        case 3: Program.zadanie3(); Console.WriteLine(""); break;
                        default: Console.WriteLine("\tВы ошиблись номером\n"); break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"!Что-то введено не так!\nЕще раз!\n\n");
                    o = 1;
                }
            }
        }
    }
}
