using System;
using System.Text;

namespace pract7_1
{
    class Program
    {
        static void zadanie1()
        {
            try
            {
                Console.Write("I. Разработать программу, которая для заданной строки s \nудваивает каждое вхождение заданного символа x\n\n");
                Console.Write("Ваша строка: ");
                StringBuilder a = new StringBuilder(Console.ReadLine());
                Console.Write("Введите символ x: ");
                char x = char.Parse(Console.ReadLine());
                bool flag = true;
                for (int i = 0; i < a.Length; ++i)
                {
                    if (a[i] == x)
                    {
                        a.Insert(i + 1, x);
                        ++i;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine("\nИзмененная строка: " + a);
                }
                else
                {
                    Console.WriteLine("\nТакого символа нет");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n\tЧто-то не так");
            }
        }

        static void zadanie2()
        {
            try
            {
                Console.Write("II. Дана строка, в которой содержится осмысленное текстовое \nсообщение. Слова сообщения разделяются пробелами и \nзнаками препинания. Удалить из сообщения все повторяющиеся \nслова (без учета регистра).\n\n");
                Console.Write("Ваша строка: ");
                StringBuilder b = new StringBuilder(Console.ReadLine());
                StringBuilder a = new StringBuilder();
                a.Append(b);
                bool flag = true;

                for (int i = 0; i < b.Length; i++)
                    if (char.IsPunctuation(b[i]))
                    {
                        b.Replace($"{b[i]}", $" {b[i]}");
                        i++;
                    }

                for (int i = 0; i < a.Length;)
                    if (char.IsPunctuation(a[i]))
                    {
                        a.Remove(i, 1);
                    }
                    else ++i;
                string str = a.ToString();
                string[] s = str.Split(' ');
                string bstr = str.ToLower();
                string[] bs = bstr.Split(' ');
                int k = 0;

                for (int i = 0; i < bs.Length; i++)
                {
                    for (int j = 0; j < bs.Length; j++)
                    {
                        if (bs[i] == bs[j])
                        {
                            k++;
                        }
                    }
                    if (k > 1)
                    {
                        if (i==0)
                        {
                            b.Replace($"{s[i]}", "");
                        }
                        else
                        {
                            b.Replace($"{s[i]} ", "");
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                    k = 0;
                }
                if (flag == true)
                {
                    for (int i = 0; i < b.Length; i++)
                        if (char.IsPunctuation(b[i]))
                        {
                            b.Remove(i - 1, 1);
                        }
                    Console.WriteLine("\nИзмененная строка: " + b);
                }
                else
                {
                    Console.WriteLine("\nПовторяющихся слов нет");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n\tЧто-то не так");
            }
        }

        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("\t~Всего 2 задания~\n0-выход\n");
            while (n != 0)
            {
                try
                {
                    Console.Write("\nВедите номер задания: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (n)
                    {
                        case 0: Console.WriteLine("\t~Выход~"); break;
                        case 1: zadanie1(); Console.WriteLine(""); break;
                        case 2: zadanie2(); Console.WriteLine(""); break;
                        default: Console.WriteLine("\tВы ошиблись номером\n"); break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"\n!Что-то введено не так!\nЕще раз!\n");
                }
            }
        }
    }
}
