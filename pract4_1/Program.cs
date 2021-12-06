using System;
using System.Text;

namespace pract4_1
{
    class Program
    {
        static double f1(double x, int n)
        {
            if (n==0)
            {
                return 1;
            }
            else if (n<0)
            {
                return 1/f1(x, Math.Abs(n));
            }
            else
            {
                return x*f1(x, n - 1);
            }
        }
        static void zadanie1()
        {
            int n, o = 1;
            double x, z = 0;
            Console.WriteLine("I. Разработать рекурсивный метод \n(возвращающий значение) для вычисления \n(x–вещественное, x!=0, а n–целое) \n");
            while (o == 1)
            {
                try
                {
                    Console.Write("\tx: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("\tn: ");
                    n = int.Parse(Console.ReadLine());
                    z += f1(x, n);               
                    Console.WriteLine($"\n\n\t~ Ответ: {Math.Round(z, 5)} ~\n");
                    o = 0;
                }
                catch (Exception)
                {
                    Console.WriteLine($"!Что-то введено не так!\nЕще раз!\n\n");
                }
            }
        }
        static void stroka(int n)
        {
            StringBuilder str = new StringBuilder();
            for (int i = n; i > 0; i--)
            {
                str.Append(i + " ");
            }
            Console.WriteLine($"\t{str}");
        }
        static void f2(int n)
        {
            StringBuilder str = new StringBuilder();
            if (n > 0)
            {
                f2(n - 1);
                stroka(n);
            }    
        }
        static void zadanie2()
        {
            int n;
            Console.WriteLine("II.Разработка рекурсивных методов \n(не возвращающих значений)\nДано натуральное число n. Разработать \nрекурсивный метод для вывода на экран \nпоследовательности чисел\n");
            try
            {
                Console.Write("Введите n для последовательности чисел: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                f2(n);
            }
            catch (Exception)
            {
                Console.WriteLine($"!Что-то введено не так!\nЕще раз!\n\n");
            }
        }
        
        static void Main(string[] args)
        {
            int n = 10, o = 1;
            Console.WriteLine("\t~Всего 2 задания~\n0-выход\n");
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
