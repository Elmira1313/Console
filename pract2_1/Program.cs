using System;

namespace pract2_1
{
    class Program
    {
        static void zadanie1 ()
        {
            double x, y;
            string sx, sy;
            Console.WriteLine("I. Дана точка на плоскости с координатами (х, у). \nСоставить программу, которая выдает одно из сооб-\nщений «Да», «Нет», «На границе» в зависимости от \nтого, лежит ли точка внутри заштрихованной области, \nвне заштрихованной области или на ее границе.\n");
            do
            {
                Console.Write("x: ");
                sx = Console.ReadLine();
                Console.Write("y: ");
                sy = Console.ReadLine();
                Console.WriteLine();

            } while (!Double.TryParse(sx, out y) || !Double.TryParse(sy, out y));
            if (Double.TryParse(sx, out x) && Double.TryParse(sy, out y))
            {
                if (x * x + y * y < 625 && y < 0 && y < -1*(Math.Abs(x)))
                    Console.WriteLine("\tТочка внутри");
                else if (x * x + y * y == 625 || y == 0 || y == -1*(Math.Abs(x)))
                    Console.WriteLine("\tТочка на границе");
                else Console.WriteLine("\tТочка вне области");
            }                  
        }
        static void zadanie2()
        {
            int m;
            string sm;
            Console.WriteLine("II. С 1 января 1990 года по некоторый день прошло \nm месяцев, определить название текущего месяца.\n");
            do
            {
                Console.Write("Введите месяц от 1 января 1990 года: ");
                sm = Console.ReadLine();                
                Console.WriteLine();

            } while (!int.TryParse(sm, out m));
            if (int.TryParse(sm, out m))
            {
                while (m>12)
                {
                    m = m - 12;
                }
                switch(m)
                {
                    case 1: Console.WriteLine("\t~Январь~"); break;
                    case 2: Console.WriteLine("\t~Февраль~"); break;
                    case 3: Console.WriteLine("\t~Март~"); break;
                    case 4: Console.WriteLine("\t~Апрель~"); break;
                    case 5: Console.WriteLine("\t~Май~"); break;
                    case 6: Console.WriteLine("\t~Июнь~"); break;
                    case 7: Console.WriteLine("\t~Июль~"); break;
                    case 8: Console.WriteLine("\t~Август~"); break;
                    case 9: Console.WriteLine("\t~Сентябрь~"); break;
                    case 10: Console.WriteLine("\t~Октябрь~"); break;
                    case 11: Console.WriteLine("\t~Ноябрь~"); break;
                    case 12: Console.WriteLine("\t~Декабрь~"); break;
                    default: Console.WriteLine("ВЫ ОШИБЛИСЬ"); break;
                }
            }
        }
        static void zadanie3()
        {
            double n = 2;
            Console.WriteLine("III. Вывести на экран таблицу перевода расстояний в \nдюймах в сантиметры для значений 2, 4, 6,.., 12 дюймов \n(1 дюйм = 25.4 мм).\n");
            Console.WriteLine("while");
            while (n<=12)
            {
                Console.WriteLine($"\t{n} дюйм\t   {Math.Round((n*25.4), 2)} mm");
                n += 2;
            }
            n = 2;
            Console.WriteLine();
            Console.WriteLine("do...while");
            do
            {
                Console.WriteLine($"\t{n} дюйм\t   {Math.Round((n * 25.4), 2)} mm");
                n += 2;
            } while (n <= 12);
            Console.WriteLine();
            Console.WriteLine("for");
            for (n=2; n <= 12; n+=2)
            {
                Console.WriteLine($"\t{n} дюйм\t   {Math.Round((n * 25.4), 2)} mm");
            }
        }
        static void zadanie4()
        {
            int k = 5;
            Console.WriteLine("IV. Вывести на экран числа \nследующим образом\n");
            for (int i = 6; i<=10; ++i, Console.WriteLine())
            {
                for(int j=0; j<k; j++)
                {
                    Console.Write(" " + i);
                }
                k--;  
            }

        }
        static void Main(string[] args)
        {
            int n = 10;
            string sn;
            Console.WriteLine("\t~Всего 4 задания~\n0-выход\n");
            while (n != 0)
            {                
                do
                {
                    Console.Write("Ведите номер задания: ");
                    sn = Console.ReadLine();
                    Console.WriteLine();

                } while (!int.TryParse(sn, out n));
                if (int.TryParse(sn, out n))
                {
                    switch (n)
                    {
                        case 0: Console.WriteLine("\t~Выход~"); break;
                        case 1: Program.zadanie1(); Console.WriteLine(""); break;
                        case 2: Program.zadanie2(); Console.WriteLine(""); break;
                        case 3: Program.zadanie3(); Console.WriteLine(""); break;
                        case 4: Program.zadanie4(); Console.WriteLine(""); break;
                        default: Console.WriteLine("Всего 4 задания\n"); break;
                    }
                }
            }
        }
    }
}
