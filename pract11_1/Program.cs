using System;

namespace pract11_1
{
    class MyArray
    {
        double[,] DoubleArray;
        int n, m;

        public MyArray(int N, int M)
        {
            n = N;
            m = M;
            DoubleArray = new double[n, m];
        }

        public void Vvod()
        {
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write($"a[{i},{j}] = ");
                    DoubleArray[i, j] = int.Parse(Console.ReadLine());
                }
        }

        public void Vivod()
        {
            for (int i = 0; i < DoubleArray.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < DoubleArray.GetLength(1); ++j)
                {
                    Console.Write( $"{Math.Round(DoubleArray[i, j], 1), -5}");
                }
        }

        public void MySort()
        {
            double temp;

            for (int i = 0; i < DoubleArray.GetLength(0); i++)
            {
                for (int j = 1; j < DoubleArray.GetLength(1); j++)
                {
                    if (DoubleArray[i, j] > DoubleArray[i, j - 1])
                    {
                        temp = DoubleArray[i, j];
                        DoubleArray[i, j] = DoubleArray[i, j - 1];
                        DoubleArray[i, j - 1] = temp;
                    }
                }
                for (int j = 0; j < DoubleArray.GetLength(1) - 1; j++)
                {
                    if (DoubleArray[i, j] < DoubleArray[i, j + 1])
                    {
                        temp = DoubleArray[i, j];
                        DoubleArray[i, j] = DoubleArray[i, j + 1];
                        DoubleArray[i, j + 1] = temp;
                    }
                }
            }
            
        }

        public int Line
        {
            get
            {
                return DoubleArray.Length;
            }
        }

        public double Incr
        {
            set
            {
                for (int i = 0; i < DoubleArray.GetLength(0); i++)
                {
                    for (int j = 0; j < DoubleArray.GetLength(1); j++)
                    {
                        DoubleArray[i, j] = DoubleArray[i, j] + Math.Round(value, 1);
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x, n, m;
                double p;
                Console.WriteLine("\t~Класс MyArray~\n");
                Console.Write("Количество объектов класса: ");
                x = int.Parse(Console.ReadLine());

                MyArray[] a = new MyArray[x];
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Объект {i + 1}");
                    Console.Write("n: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("m: ");
                    m = int.Parse(Console.ReadLine());

                    a[i] = new MyArray(n, m);
                    Console.WriteLine();
                }

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Заполняем объект {i + 1}");
                    a[i].Vvod();
                    Console.WriteLine();
                }

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Объект {i + 1}");
                    a[i].Vivod();
                    Console.WriteLine();
                }

                Console.WriteLine("\n\tСортируем строки объектов\n");

                for (int i = 0; i < x; i++)
                {
                    a[i].MySort();
                    Console.WriteLine($"Отсортированный объект {i + 1}");
                    a[i].MySort();
                    a[i].Vivod();
                    Console.WriteLine();
                }

                Console.WriteLine("\nКоличество элементов объектов");

                for (int i = 0; i < x; i++)
                {
                    Console.Write($"Объект {i + 1}: {a[i].Line}");
                    Console.WriteLine();
                }

                Console.Write("\n\nУвеличить каждый элемент объектов на: ");
                p = double.Parse(Console.ReadLine());
                Console.WriteLine();

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Объект {i + 1}");
                    a[i].Incr = p;
                    a[i].Vivod();
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Что-то не так!");
            }
            
        }
    }
}
