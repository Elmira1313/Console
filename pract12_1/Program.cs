using System;

namespace pract12_1
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
                    Console.Write($"{Math.Round(DoubleArray[i, j], 1),-5}");
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

        public static MyArray operator ++(MyArray a)
        {
            for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < a.DoubleArray.GetLength(1); j++)
                {
                    a.DoubleArray[i, j] = a.DoubleArray[i, j] + 1;
                }
            }
            return a;
        }

        public static MyArray operator --(MyArray a)
        {
            for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < a.DoubleArray.GetLength(1); j++)
                {
                    a.DoubleArray[i, j] = a.DoubleArray[i, j] - 1;
                }
            }
            return a;
        }

        public static bool operator true(MyArray a)
        {
            for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
            {
                for (int j = 1; j < a.DoubleArray.GetLength(1); j++)
                {
                    if (a.DoubleArray[i, j] < a.DoubleArray[i, j - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(MyArray a)
        {
            for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
            {
                for (int j = 1; j < a.DoubleArray.GetLength(1); j++)
                {
                    if (a.DoubleArray[i, j] > a.DoubleArray[i, j - 1])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static MyArray operator *(MyArray a, MyArray b)
        {
            if (a.m == b.n)
            {
                MyArray c = new MyArray(a.n, b.m);
                double sum = 0;
                for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
                {
                    for (int j = 0; j < b.DoubleArray.GetLength(1); j++)
                    {
                        for (int k = 0; k < b.DoubleArray.GetLength(0); k++)
                        {
                            sum += a.DoubleArray[i, k] * b.DoubleArray[k, j];
                        }
                        c.DoubleArray[i, j] = sum;
                        sum = 0;
                    }
                }
                return c;
            }
            else
            {
                return null;
            }
        }

        public static MyArray operator *(MyArray a, double b)
        {
            MyArray c = new MyArray(a.n, a.m);
            double sum = 0;
            for (int i = 0; i < a.DoubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < a.DoubleArray.GetLength(1); j++)
                {
                    c.DoubleArray[i, j] = a.DoubleArray[i, j] * b;
                }
            }
            return c;
        }

        public static explicit operator double[][](MyArray a)
        {
            double[][] buf = new double[a.n][];
            for (int i = 0; i < a.n; i++)
            {
                buf[i] = new double[a.m];
                for (int j = 0; j < a.m; j++)
                {
                    buf[i][j] = a.DoubleArray[i, j];
                }
            }
            return buf;
        }

        public static explicit operator MyArray(double[][] a)
        {
            int n = a.GetLength(0);
            int m = a[0].Length;
            MyArray b = new MyArray(n, m);
            for (int chet = 1; chet < a.GetLength(0); chet++)
            {
                if (a[chet].Length == a[chet - 1].Length)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            b.DoubleArray[i, j] = a[i][j];
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            return b;
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

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Объект {i + 1} true/false");
                    if (a[i])
                    {
                        Console.WriteLine("Элементы строк возрают");
                    }
                    else
                    {
                        Console.WriteLine("Элементы строк не возрают");
                    }
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

                Console.WriteLine();

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Объект {i + 1}++");
                    a[i]++;
                    a[i].Vivod();
                    Console.WriteLine();
                }

                Console.WriteLine();

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Объект {i + 1}--");
                    a[i]--;
                    a[i].Vivod();
                    Console.WriteLine();
                }

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Объект {i + 1}");
                    if (a[i])
                    {
                        Console.WriteLine("Элементы строк возрают");
                    }
                    else
                    {
                        Console.WriteLine("Элементы строк не возрают");
                    }
                    Console.WriteLine();
                }

                MyArray s;
                int y = a.Length - 1;
                s = a[0] * a[y];
                if (s != null)
                {
                    Console.WriteLine("Произведение 1 и последнего объектов:");
                    s.Vivod();
                }
                else
                {
                    Console.WriteLine("\nОбъекты нельзя перемножить");
                }

                Console.WriteLine();
                Console.Write("Умножить объекты на: ");
                p = double.Parse(Console.ReadLine());
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine($"Объект {i + 1} * {p}");
                    a[i] = a[i] * p;
                    a[i].Vivod();
                    Console.WriteLine();
                }

                Console.WriteLine("\nПреобразование объекта 1 в ступенчатые массив");
                double[][] r = (double[][])a[0];
                for (int i = 0; i < r.Length; ++i, Console.WriteLine())
                    for (int j = 0; j < r[i].Length; ++j)
                        Console.Write($"{Math.Round(r[i][j],1), -5}");

                Console.WriteLine("\nПреобразование ступенчатого массива обратно\nв объект");
                MyArray bufa = (MyArray)r;
                bufa.Vivod();
            }
            catch
            {
                Console.WriteLine("Что-то не так!");
            }
        }
    }
}
