using System;

namespace pract6_1
{
    class Program
    {
        static int[] Input()
        {
            Console.Write("Введите размерность одномерного массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write($"a[{i}] = "); ;
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static int[,] Input(out int n, out int m)
        {
            Console.WriteLine("Введите размерность двумерного массива");
            Console.Write("n = ");
            m = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i) 
                Console.Write($"{a[i]} ");
            Console.WriteLine();
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write($"{a[i, j]} ");
        }

        static int Change(int[] a)
        {
            int n = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] % 2 != 0)
                {
                    n++;
                }
            }
            return n;
        }        
        
        static int Change(int[,] a)
        {
            int n = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                    if (a[i, j] % 2 != 0)
                    {
                        n++;
                    }
            return n;
        }


        static void MASS1()
        {
            Console.WriteLine("1. Дана последовательность целых чисел.\nПодсчитать количество нечетных элементов.\n\n");
            int n1, n2;
            Console.WriteLine("\t~Одномерный массив~\n");
            int[] myArray1 = Input();
            Console.WriteLine();
            Print(myArray1);
            n1 = Change(myArray1);
            Console.WriteLine($"Количество нечетных элементов: {n1}\n\n");
            
            int n, m;
            Console.WriteLine("\t~Двумерный массив~\n");
            int[,] myArray2 = Input(out n, out m);
            Console.WriteLine();
            Print(myArray2);
            n2 = Change(myArray2);
            Console.WriteLine($"Количество нечетных элементов: {n2}\n");
        }

        static double[] Input2()
        {
            Console.Write("Введите размерность одномерного массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double[] a = new double[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write($"a[{i}] = "); ;
                a[i] = Double.Parse(Console.ReadLine());
            }
            return a;
        }

        static void Print(double[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                Console.Write($"{a[i]} ");
            Console.WriteLine();
        }

        static double Max(double[] a)
        {
            double max = a[0];
            for (int i = 1; i < a.Length; ++i)
                if (a[i] > max) max = a[i];
            return max;
        }

        static void MASS2()
        {
            Console.WriteLine("2. Дана последовательность из n действительных чисел.\nНайти номер последнего максимального элемента.\n\n");
            Console.WriteLine("\t~Одномерный массив~\n");
            double[] myArray = Input2();
            Console.WriteLine();
            Print(myArray);
            double max = Max(myArray);
            int n=0;
            for (int i = 0; i < myArray.Length; ++i)
                if (myArray[i] == max) n=i;
            Console.WriteLine($"Номер последнего максимального элемента: {n}\n");

        }
        static void Rezalt(int[,] a)
        {
            int s = a.GetLength(1), r, buf;
            if (s%2==0)
            {
                r = s / 2 - 1;

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    buf = a[i, r];
                    a[i, r] = a[i, r+1];
                    a[i, r + 1] = buf;
                }
            }
            else
            {
                r = (s-1) / 2;
                for (int i = 0; i < a.GetLength(0); ++i)
                {
                        buf = a[i, 0];
                        a[i, 0] = a[i, r];
                        a[i, r] = buf;
                }
            }
            
        }
        static int[,] Input3(out int n)
        {
            Console.WriteLine("Введите размерность массива");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] a = new int[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write($"a[{i},{j}] = "); ;
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        static void MASS3()
        {
            int n, m;
            Console.WriteLine("3. Дан массив размером nxn, элементы которого целые числа.\nПоменять местами два средних столбца, если количество столбцов четное, \nи первый со средним столбцом, если количество столбцов нечетное.\n\n");
            Console.WriteLine("\t~Двумерный массив~\n");
            int[,] myArray = Input3(out n);
            Console.WriteLine();
            Print(myArray);
            Rezalt(myArray);
            Console.WriteLine("\nИзмененный массив:\n");
            Print(myArray);
            Console.WriteLine();
        }


        static int[][] Input4()
        {
            Console.WriteLine("Введите размерность массива");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[][] a = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        static void Print41(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                Console.Write($"{a[i]} ");
        }

        static void Print42(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                for (int j = 0; j < a[i].Length; ++j)
                    Console.Write($"{a[i][j]} ");
        }

        static int[] sum(int[][] a)
        { 
            int n;
            int[] arr = new int [a.Length];
            for (int i = 0; i < a.Length; ++i)
                for (int j = 0; j < a.Length; ++j)
                    if (a[i][j] >= 0 && a[i][j]%2==0) 
                    {
                        arr[j] += a[i][j]; 
                    }
            return arr;
        }

        static void MASS4()
        {
            Console.WriteLine("4. Дан массив размером nxn, элементы которого целые числа.\nДля каждого столбца подсчитать сумму четных положительных \nэлементов и записать данные в новый массив.\n\n");
            Console.WriteLine("\t~Ступенчатый массив~\n");
            int[][] myArray = Input4();
            Console.WriteLine("\nИсходный массив:");
            Print42(myArray);
            int[] rez = new int[myArray[0].Length];
            for (int i = 0; i < myArray.Length; ++i)
                for (int j = 0; j < myArray[i].Length; ++j)
                    rez [j] = sum(myArray)[j];

            Console.WriteLine("\nНовый массив:");
            Print41(rez);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = 10, o = 1;
            Console.WriteLine("\t~Всего 4 задания~\n0-выход\n");
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
                        case 1: MASS1(); Console.WriteLine(""); break;
                        case 2: MASS2(); Console.WriteLine(""); break;
                        case 3: MASS3(); Console.WriteLine(""); break;
                        case 4: MASS4(); Console.WriteLine(""); break;
                        default: Console.WriteLine("\tВы ошиблись номером\n"); break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"!Что-то введено не так!\nЕще раз!\n\n");
                }
            }

        }

    }
}
